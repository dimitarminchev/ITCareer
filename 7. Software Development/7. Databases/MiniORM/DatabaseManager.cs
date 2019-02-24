using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MiniORM
{
    public class IdAttribute : Attribute
    {
    }

    public class ColumnAttribute : Attribute
    {
        public string ColumnName { get; set; }
    }

    public class EntityAttribute : Attribute
    {
        public string TableName { get; set; }
    }

    public class DatabaseManager : IDatabaseContext
    {
        private MySqlConnection connection;
        private readonly string connectionString;
        private readonly bool isCodeFirst;

        public DatabaseManager(string connectionString, bool isCodeFirst)
        {
            this.connectionString = connectionString;
            this.isCodeFirst = isCodeFirst;
        }

        public bool Persist(object entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Cannot persist null entity");
            }

            if (this.isCodeFirst && !this.CheckIfTableExists(entity.GetType()))
            {
                this.CreateTable(entity.GetType());
            }

            Type entityType = entity.GetType();
            FieldInfo idInfo = this.GetId(entityType);
            int id = (int)idInfo.GetValue(entity);

            if (id <= 0)
            {
                return this.Insert(entity, idInfo);
            }

            return this.Update(entity, idInfo);
        }

        private bool Update(object entityType, FieldInfo idInfo)
        {
            int numberOfAffectedRows = 0;

            string updateString = this.PrepareEntityUpdateString(entityType, idInfo);
            using (this.connection = new MySqlConnection(this.connectionString))
            {
                this.connection.Open();
                MySqlCommand updateCommand = new MySqlCommand(updateString, this.connection);
                numberOfAffectedRows = updateCommand.ExecuteNonQuery();
            }

            return numberOfAffectedRows > 0;
        }

        private string PrepareEntityUpdateString(object entity, FieldInfo idInfo)
        {
            StringBuilder updateString = new StringBuilder();
            updateString.Append($"UPDATE {this.GetTableName(entity.GetType())} SET ");

            StringBuilder settings = new StringBuilder();

            FieldInfo[] columnFields = entity.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .Where(x => x.IsDefined(typeof(ColumnAttribute))).ToArray();

            foreach (FieldInfo columnField in columnFields)
            {
                settings.Append($"{this.GetColumnName(columnField)} = '{columnField.GetValue(entity)}', ");
            }

            settings.Remove(settings.Length - 2, 2);
            updateString.Append(settings);

            updateString.Append($" WHERE Id = {idInfo.GetValue(entity)}");

            return updateString.ToString();
        }

        private bool Insert(object entityType, FieldInfo idInfo)
        {
            int numberOfAffectedRows = 0;

            string insertionString = this.PrepareEntityInsertionString(entityType);
            using (this.connection = new MySqlConnection(this.connectionString))
            {
                this.connection.Open();
                MySqlCommand insertionCommand = new MySqlCommand(insertionString, this.connection);
                numberOfAffectedRows = insertionCommand.ExecuteNonQuery();

                string query = $"SELECT MAX(Id) FROM {this.GetTableName(entityType.GetType())}";
                MySqlCommand getLastIdCommand = new MySqlCommand(query, this.connection);
                int id = (int)getLastIdCommand.ExecuteScalar();
                idInfo.SetValue(entityType, id);
            }

            return numberOfAffectedRows > 0;
        }

        private string PrepareEntityInsertionString(object entity)
        {
            StringBuilder insertionString = new StringBuilder();
            StringBuilder columnNamesString = new StringBuilder();
            StringBuilder valueString = new StringBuilder();

            insertionString.Append($"INSERT INTO {this.GetTableName(entity.GetType())}(");

            FieldInfo[] columnFields = entity.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .Where(x => x.IsDefined(typeof(ColumnAttribute))).ToArray();

            foreach (FieldInfo columnField in columnFields)
            {
                string value = columnField.GetValue(entity).ToString();
                columnNamesString.Append($"{this.GetColumnName(columnField)}, ");
                valueString.Append($"'{value}', ");
            }

            columnNamesString = columnNamesString.Remove(columnNamesString.Length - 2, 2);
            valueString = valueString.Remove(valueString.Length - 2, 2);

            insertionString.Append(columnNamesString);
            insertionString.Append(") VALUES(");
            insertionString.Append(valueString);
            insertionString.Append(")");

            return insertionString.ToString();
        }

        private bool CheckIfTableExists(Type type)
        {
            string query =
                $"SELECT COUNT(name) " +
                $"FROM sys.sysobjects " +
                $"WHERE [Name] = '{this.GetTableName(type)}' AND [xtype] = 'U'";

            int numberOfTables = 0;
            using (this.connection = new MySqlConnection(this.connectionString))
            {
                this.connection.Open();
                MySqlCommand command = new MySqlCommand(query, this.connection);
                numberOfTables = (int)command.ExecuteScalar();
            }

            return numberOfTables > 0;
        }

        public T FindById<T>(int id)
        {
            T wantedObject = default(T);
            string query = $"SELECT * FROM {this.GetTableName(typeof(T))} WHERE Id = {id}";
            using (this.connection = new MySqlConnection(this.connectionString))
            {
                this.connection.Open();
                MySqlCommand command = new MySqlCommand(query, this.connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        throw new InvalidOperationException("No entity was found with id " + id);
                    }

                    reader.Read();
                    wantedObject = this.CreateEntity<T>(reader);
                }

            }

            return wantedObject;
        }

        private T CreateEntity<T>(MySqlDataReader reader)
        {
            object[] columns = new object[reader.FieldCount];
            reader.GetValues(columns);

            Type[] types = new Type[columns.Length - 1];
            object[] fieldValues = new object[columns.Length - 1];


            for (int i = 1; i < columns.Length; i++)
            {
                types[i - 1] = columns[i].GetType();
                fieldValues[i - 1] = columns[i];
            }

            T createdObject = (T)typeof(T).GetConstructor(types).Invoke(fieldValues);

            FieldInfo idInfo = createdObject.GetType()
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .FirstOrDefault(x => x.IsDefined(typeof(IdAttribute)));


            idInfo.SetValue(createdObject, columns[0]);

            return createdObject;
        }

        public IEnumerable<T> FindAll<T>()
        {
            return this.FindAll<T>(null);
        }

        public IEnumerable<T> FindAll<T>(string where)
        {
            List<T> entities = new List<T>();
            string selectionString = $"SELECT * FROM {this.GetTableName(typeof(T))}";

            if (where != null)
            {                
                selectionString = String.Concat(selectionString, $" WHERE {where}");
            }

            using (this.connection = new MySqlConnection(this.connectionString))
            {
                this.connection.Open();

                MySqlCommand selectionCommand = new MySqlCommand(selectionString, this.connection);
                MySqlDataReader reader = selectionCommand.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        entities.Add(this.CreateEntity<T>(reader));
                    }
                }
            }

            return entities;
        }

        public T FindFirst<T>()
        {
            return this.FindFirst<T>(null);
        }

        public T FindFirst<T>(string where)
        {
            T result = default(T);
            string selectionString = $"SELECT TOP 1 * FROM {this.GetTableName(typeof(T))} WHERE 1=1 AND ";

            if (where != null)
            {
                selectionString += where;
            }

            using (this.connection = new MySqlConnection(this.connectionString))
            {
                this.connection.Open();
                MySqlCommand selectionCommand = new MySqlCommand(selectionString, this.connection);
                MySqlDataReader reader = selectionCommand.ExecuteReader();
                reader.Read();
                result = this.CreateEntity<T>(reader);
            }

            return result;
        }

        public void Delete<T>(object entity)
        {
            var firstOrDefault = entity.GetType()
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .FirstOrDefault(x => x.IsDefined(typeof(IdAttribute)));

            if (firstOrDefault == null)
            {
                throw new NullReferenceException("The given entity has no field with attribute Id!");
            }

            this.DeleteById<T>((int)firstOrDefault.GetValue(entity));
        }

        public void DeleteById<T>(int id)
        {
            string deletionString = $"DELETE FROM {this.GetTableName(typeof(T))} WHERE ID = @id";
            using (this.connection = new MySqlConnection(this.connectionString))
            {
                this.connection.Open();
                MySqlCommand command = new MySqlCommand(deletionString, this.connection);
                command.Parameters.AddWithValue("@id", id);
                int numberofDeletedItems = command.ExecuteNonQuery();

                if (numberofDeletedItems == 0)
                {
                    throw new ArgumentException($"Id {numberofDeletedItems} not found!");
                }
            }
        }

        private void CreateTable(Type entity)
        {
            string creationString = this.PrepareTableCreationString(entity);
            using (this.connection = new MySqlConnection(this.connectionString))
            {
                this.connection.Open();
                MySqlCommand command = new MySqlCommand(creationString, this.connection);
                command.ExecuteNonQuery();
            }
        }

        private string PrepareTableCreationString(Type entity)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"CREATE TABLE {this.GetTableName(entity)} (");
            builder.Append($"Id INT PRIMARY KEY IDENTITY(1,1), ");

            FieldInfo[] columnsInfos =
                entity.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .Where(x => x.IsDefined(typeof(ColumnAttribute)))
                .ToArray();


            foreach (FieldInfo columnField in columnsInfos)
            {
                builder.Append($"{this.GetColumnName(columnField)} {this.GetTypeToDB(columnField)}, ");
            }
            builder.Remove(builder.Length - 2, 2);
            builder.Append(")");

            return builder.ToString();
        }

        private string GetTypeToDB(FieldInfo field)
        {
            switch (field.FieldType.Name)
            {
                case "Int32":
                    return "int";
                case "String":
                    return "varchar(max)";
                case "DateTime":
                    return "datetime";
                case "Boolean":
                    return "bit";
                case "Single":
                case "Double":
                case "Decimal":
                    return "decimal(10, 4)";
                default:
                    Console.WriteLine(field.FieldType.Name);
                    throw new ArgumentException("No such present type - try extending the framework!");
            }
        }

        private FieldInfo GetId(Type entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Cannot get id for null type!");
            }

            FieldInfo id =
                entity.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                    .FirstOrDefault(x => x.IsDefined(typeof(IdAttribute)));

            if (id == null)
            {
                throw new ArgumentNullException("No id field was found the current class!");
            }

            return id;
        }

        private string GetTableName(Type entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Table null!");
            }

            if (!entity.IsDefined(typeof(EntityAttribute)))
            {
                throw new ArgumentException("Cannot get table name of entity!");
            }

            string tableName = entity.GetCustomAttribute<EntityAttribute>().TableName;

            if (tableName == null)
            {
                throw new ArgumentNullException("Table name cannot be null!");
            }

            return tableName;
        }

        private string GetColumnName(FieldInfo field)
        {
            if (field == null)
            {
                throw new ArgumentNullException("Field cannot be null");
            }

            if (!field.IsDefined(typeof(ColumnAttribute)))
            {
                return field.Name;
            }

            string columnName = field.GetCustomAttribute<ColumnAttribute>().ColumnName;
            if (columnName == null)
            {
                throw new ArgumentNullException("Column name cannot be null!");
            }

            return columnName;

        }
    }
}
