namespace MiniORM
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.Data.SqlClient;
	using System.Linq;

	/// <summary>
	/// Used for accessing a database, inserting/updating/deleting entities
	/// and mapping database columns to entity classes.
	/// </summary>
	internal class DatabaseConnection
	{
		private readonly SqlConnection connection;

		private SqlTransaction transaction;

		public DatabaseConnection(string connectionString)
		{
			this.connection = new SqlConnection(connectionString);
		}

		private SqlCommand CreateCommand(string queryText, params SqlParameter[] parameters)
		{
			var command = new SqlCommand(queryText, this.connection, this.transaction);

			foreach (var param in parameters)
			{
				command.Parameters.Add(param);
			}

			return command;
		}

		public int ExecuteNonQuery(string queryText, params SqlParameter[] parameters)
		{
			using (var query = CreateCommand(queryText, parameters))
			{
				var result = query.ExecuteNonQuery();

				return result;
			}
		}

		public IEnumerable<string> FetchColumnNames(string tableName)
		{
			var rows = new List<string>();

			var queryText = $@"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}'";

			using (var query = CreateCommand(queryText))
			{
				using (var reader = query.ExecuteReader())
				{
					while (reader.Read())
					{
						var column = reader.GetString(0);

						rows.Add(column);
					}
				}
			}

			return rows;
		}

		public IEnumerable<T> ExecuteQuery<T>(string queryText)
		{
			var rows = new List<T>();

			using (var query = CreateCommand(queryText))
			{
				using (var reader = query.ExecuteReader())
				{
					while (reader.Read())
					{
						var columnValues = new object[reader.FieldCount];
						reader.GetValues(columnValues);

						var obj = reader.GetFieldValue<T>(0);
						rows.Add(obj);
					}
				}
			}

			return rows;
		}

		public IEnumerable<T> FetchResultSet<T>(string tableName, params string[] columnNames)
		{
			var rows = new List<T>();

			var escapedColumns = string.Join(", ", columnNames.Select(EscapeColumn));
			var queryText = $@"SELECT {escapedColumns} FROM {tableName}";

			using (var query = CreateCommand(queryText))
			{
				using (var reader = query.ExecuteReader())
				{
					while (reader.Read())
					{
						var columnValues = new object[reader.FieldCount];
						reader.GetValues(columnValues);

						var obj = MapColumnsToObject<T>(columnNames, columnValues);
						rows.Add(obj);
					}
				}
			}

			return rows;
		}

		public void InsertEntities<T>(IEnumerable<T> entities, string tableName, string[] columns)
			where T : class
		{
			var identityColumns = GetIdentityColumns(tableName);

			var columnsToInsert = columns.Except(identityColumns).ToArray();

			var escapedColumns = columnsToInsert.Select(EscapeColumn).ToArray();

			var rowValues = entities
				.Select(entity => columnsToInsert
					.Select(c => entity.GetType().GetProperty(c).GetValue(entity))
					.ToArray())
				.ToArray();

			var rowParameterNames = Enumerable.Range(1, rowValues.Length)
				.Select(i => columnsToInsert.Select(c => c + i).ToArray())
				.ToArray();

			var sqlColumns = string.Join(", ", escapedColumns);

			var sqlRows = string.Join(", ",
				rowParameterNames.Select(p =>
					string.Format("({0})",
						string.Join(", ", p.Select(a => $"@{a}")))));

			var query = string.Format(
				"INSERT INTO {0} ({1}) VALUES {2}",
				tableName,
				sqlColumns,
				sqlRows
			);

			var parameters = rowParameterNames
				.Zip(rowValues, (@params, values) =>
					@params.Zip(values, (param, value) =>
						new SqlParameter(param, value ?? DBNull.Value)))
				.SelectMany(p => p)
				.ToArray();

			var insertedRows = this.ExecuteNonQuery(query, parameters);

			if (insertedRows != entities.Count())
			{
				throw new InvalidOperationException($"Could not insert {entities.Count() - insertedRows} rows.");
			}
		}

		public void UpdateEntities<T>(IEnumerable<T> modifiedEntities, string tableName, string[] columns)
			where T : class
		{
			var identityColumns = GetIdentityColumns(tableName);

			var columnsToUpdate = columns.Except(identityColumns).ToArray();

			var primaryKeyProperties = typeof(T).GetProperties()
				.Where(pi => pi.HasAttribute<KeyAttribute>())
				.ToArray();

			foreach (var entity in modifiedEntities)
			{
				var primaryKeyValues = primaryKeyProperties
					.Select(c => c.GetValue(entity))
					.ToArray();

				var primaryKeyParameters = primaryKeyProperties
					.Zip(primaryKeyValues, (param, value) => new SqlParameter(param.Name, value))
					.ToArray();

				var rowValues = columnsToUpdate
					.Select(c => entity.GetType().GetProperty(c).GetValue(entity) ?? DBNull.Value)
					.ToArray();

				var columnsParameters = columnsToUpdate.Zip(rowValues, (param, value) => new SqlParameter(param, value))
					.ToArray();

				var columnsSql = string.Join(", ",
					columnsToUpdate.Select(c => $"{c} = @{c}"));

				var primaryKeysSql = string.Join(" AND ",
					primaryKeyProperties.Select(pk => $"{pk.Name} = @{pk.Name}"));

				var query = string.Format("UPDATE {0} SET {1} WHERE {2}",
					tableName,
					columnsSql,
					primaryKeysSql);

				var updatedRows = this.ExecuteNonQuery(query, columnsParameters.Concat(primaryKeyParameters).ToArray());

				if (updatedRows != 1)
				{
					throw new InvalidOperationException($"Update for table {tableName} failed.");
				}
			}
		}

		public void DeleteEntities<T>(IEnumerable<T> entitiesToDelete, string tableName, string[] columns)
			where T : class
		{
			var primaryKeyProperties = typeof(T).GetProperties()
				.Where(pi => pi.HasAttribute<KeyAttribute>())
				.ToArray();

			foreach (var entity in entitiesToDelete)
			{
				var primaryKeyValues = primaryKeyProperties
					.Select(c => c.GetValue(entity))
					.ToArray();

				var primaryKeyParameters = primaryKeyProperties
					.Zip(primaryKeyValues, (param, value) => new SqlParameter(param.Name, value))
					.ToArray();

				var primaryKeysSql = string.Join(" AND ",
					primaryKeyProperties.Select(pk => $"{pk.Name} = @{pk.Name}"));

				var query = string.Format("DELETE FROM {0} WHERE {1}",
					tableName,
					primaryKeysSql);

				var updatedRows = this.ExecuteNonQuery(query, primaryKeyParameters);

				if (updatedRows != 1)
				{
					throw new InvalidOperationException($"Delete for table {tableName} failed.");
				}
			}
		}

		private IEnumerable<string> GetIdentityColumns(string tableName)
		{
			const string identityColumnsSql =
				"SELECT COLUMN_NAME FROM (SELECT COLUMN_NAME, COLUMNPROPERTY(OBJECT_ID(TABLE_NAME), COLUMN_NAME, 'IsIdentity') AS IsIdentity FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{0}') AS IdentitySpecs WHERE IsIdentity = 1";

			var parametrizedSql = string.Format(identityColumnsSql, tableName);

			var identityColumns = ExecuteQuery<string>(parametrizedSql);

			return identityColumns;
		}

		public SqlTransaction StartTransaction()
		{
			this.transaction = this.connection.BeginTransaction();
			return this.transaction;
		}

		public void Open() => this.connection.Open();

		public void Close() => this.connection.Close();

		private static string EscapeColumn(string c)
		{
			var escapedColumn = $"[{c}]";
			return escapedColumn;
		}

		private static T MapColumnsToObject<T>(string[] columnNames, object[] columns)
		{
			var obj = Activator.CreateInstance<T>();

			for (var i = 0; i < columns.Length; i++)
			{
				var columnName = columnNames[i];
				var columnValue = columns[i];

				if (columnValue is DBNull)
				{
					columnValue = null;
				}

				var property = typeof(T).GetProperty(columnName);
				property.SetValue(obj, columnValue);
			}

			return obj;
		}
	}
}