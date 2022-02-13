# 7.Databases

1. Създайте MsSQL база данни minions 
2. Инсталирайте NuGet пакета System.Data.SqlClient
3. Демонстрационен програмен фрагмент (Program.cs)
```
SqlConnection conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=minions;Integrated Security=true");
conn.Open();
using (conn)
{
	SqlCommand command = new SqlCommand("SELECT name,age FROM minions;", conn);
	SqlDataReader reader = command.ExecuteReader();
	while (reader.Read()) Console.WriteLine("Name: {0}, Age: {1}", reader[0], reader[1]);
}
```

## 1. Minions Database
```
CREATE TABLE minions (id INT, name VARCHAR(50), age INT);
INSERT INTO minions (id, name, age) VALUES ('1', 'Kevin', '15');
INSERT INTO minions (id, name, age) VALUES ('2', 'Bob', '22')
INSERT INTO minions (id, name, age) VALUES ('3', 'Steward', '42')
SELECT name,age FROM minions;
```

## 2. Villians Names
```
using (var conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=minions;Integrated Security=true"))
{
	conn.Open();
	SqlCommand sql = new SqlCommand
	(
		"SELECT V.Name, COUNT(MV.VillainId) " +
		"FROM Villains as V " +
		"JOIN MinionsVillains AS MV on MV.VillainId = V.Id " +
		"GROUP BY MV.VillainId, V.Name " +
		"HAVING COUNT(MV.VillainId) > 3", conn
	);
	var reader = sql.ExecuteReader();
	while (reader.Read())
	{
		Console.WriteLine("{0} -> {1}", reader[0], reader[1]);
	}
}
```

## 3. Minions Names
```
Console.Write("Enter villain's ID: ");
int villainID = int.Parse(Console.ReadLine());

using (var conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=minions;Integrated Security=true"))
{
	conn.Open();
	SqlCommand sql = new SqlCommand
	(
		"SELECT minions.name " + 
		"FROM minionsvillains " +
		"JOIN minions on minionsvillains.MinionId = minions.id " +
		$"WHERE minionsvillains.VillainId = @villainID", conn
	);
	sql.Parameters.AddWithValue("@villainID", villainID);
	var reader = sql.ExecuteReader();

	bool hasNames = false;
	int i = 1;
	while (reader.Read())
	{
		hasNames = true;
		Console.WriteLine("{0}. {1}", i++, reader[0]);
	}
	if (hasNames == false)
	{
		Console.WriteLine($"No villain with ID {villainID} exists in the database.");
	}

	reader.Close();
	conn.Close();
}
```

## 4. Add Minion
```
// Minion
Console.WriteLine("Minion [name age town]: ");
var minionData = Console.ReadLine().Split().ToArray();
var minionName = minionData[0];
int minionAge = int.Parse(minionData[1]);
var townName = minionData[2];

// Villain
Console.WriteLine("Villain [name]: ");
var villainName = Console.ReadLine();

// Process
using (var conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=minions;Integrated Security=true"))
{
	conn.Open();

	// 1. Search Towns By Name
	SqlCommand sql = new SqlCommand
	(
		"SELECT count(*) FROM towns WHERE towns.name = @townName", conn
	);
	sql.Parameters.AddWithValue("@townName", townName);

	// 2. Add town to the database if not exists
	if (int.Parse(sql.ExecuteScalar().ToString()) == 0)
	{
		sql = new SqlCommand("INSERT INTO Towns (Name, CountryCode) VALUES (@townName, 2)", conn);
		sql.Parameters.AddWithValue("@townName", townName);
		sql.ExecuteNonQuery();
		Console.WriteLine($"Town {townName} was added to the database.");
	}

	// 3. Search Villain by Name
	sql = new SqlCommand
	(
		"SELECT count(*) FROM villains WHERE villains.Name = @villainName", conn
	);
                sql.Parameters.AddWithValue("@villainName", villainName);

	// 4. Add Villain to the database if not exists
	if (int.Parse(sql.ExecuteScalar().ToString()) == 0)
	{
		sql = new SqlCommand("INSERT INTO Villains (Name, EvilnessFactorId) VALUES (@villainName, 4)", conn);
		sql.Parameters.AddWithValue("@villainName", villainName);
		sql.ExecuteNonQuery();
		Console.WriteLine($"Villain {villainName} was added to the database.");
	}

	// 5. Add Minion 
	sql = new SqlCommand
	(
		"INSERT INTO Minions (Name, Age, TownId) VALUES (@minionName, @minionAge, " +
		"(SELECT towns.id FROM towns WHERE towns.name = @townName)) ", conn
	);
	sql.Parameters.AddWithValue("@minionName", minionName);
	sql.Parameters.AddWithValue("@minionAge", minionAge);
	sql.Parameters.AddWithValue("@townName", townName);
	sql.ExecuteNonQuery();
	Console.WriteLine($"Minion {minionName} was added to the database.");

	// 6. Connect Minion and Villain 
	sql = new SqlCommand
	(
		"INSERT INTO MinionsVillains (MinionId, VillainId) VALUES " +
		"((SELECT minions.id FROM minions WHERE minions.name = @minionName), " +
		"(SELECT villains.id FROM villains WHERE villains.name = @villainName))", conn
	);
	sql.Parameters.AddWithValue("@minionName", minionName);
	sql.Parameters.AddWithValue("@villainName", villainName);
	sql.ExecuteNonQuery();
	Console.WriteLine($"Successfully added {minionName} to be minion of {villainName}.");
}
```

## 5. Change Register
```
// Towns
var towns = new Dictionary<int, string>();

// Input
Console.Write("Enter country: ");
var countryName = Console.ReadLine();

// Process
using (var conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=minions;Integrated Security=true"))
{
	conn.Open();

	// Find Country Id
	SqlCommand sql = new SqlCommand
	(
		"SELECT TOP 1 countries.id FROM countries " +
		$"WHERE countries.name = @countryName", conn
	);
	sql.Parameters.AddWithValue("@countryName", countryName);
	int countryId = int.Parse(sql.ExecuteScalar().ToString());

	// Find All Towns for selected Country
	sql = new SqlCommand
	(
		"SELECT towns.id, towns.name FROM towns" +
		$" WHERE towns.CountryCode = @countryId", conn
	);
	sql.Parameters.AddWithValue("@countryId", countryId);
	var reader = sql.ExecuteReader();
	while (reader.Read())
	{
		towns.Add(int.Parse(reader[0].ToString()), reader[1].ToString().ToUpper());
	}
	reader.Close();

	// Update the Namesof all Towns for selected Country
	foreach (var town in towns)
	{
		sql = new SqlCommand("UPDATE towns SET name = @name WHERE id=@id", conn);
		sql.Parameters.AddWithValue("@name", town.Value);
		sql.Parameters.AddWithValue("@id", town.Key);
		sql.ExecuteNonQuery();
	}

	// Finally print some information for the user
	if (towns.Count() > 0)
	{
		Console.WriteLine($"{towns.Count()} town names were affected.");
		Console.WriteLine("[" + string.Join(", ", towns.Values) + "]");
	}
	else
	{
		Console.WriteLine("No town names were affected.");
	}
}
```

## 6. Remove Villian
```
// Input
Console.Write("Enter villain id: ");
int villainId = int.Parse(Console.ReadLine());

// Process
using (var conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=minions;Integrated Security=true"))
{
	conn.Open();

	// 1. Execute query to find Villain by Id
	SqlCommand comm = new SqlCommand( $"SELECT count(*) FROM villains WHERE villains.id = @villainId", conn);
	comm.Parameters.AddWithValue("@villainId", villainId);

	// 2. Check if the villain exists
	bool existsVillain = int.Parse(comm.ExecuteScalar().ToString()) > 0;
	if (existsVillain == false)
	{
		Console.WriteLine("No such villain was found.");
	}
	else
	{
		// Get villain's name
		comm = new SqlCommand("SELECT name FROM villains WHERE villains.id = @villainId", conn);
		comm.Parameters.AddWithValue("@villainId", villainId);
		string villainName = comm.ExecuteScalar().ToString();

		// Release minions
		comm = new SqlCommand("DELETE FROM minionsvillains WHERE villainId = @villainId;", conn);
		comm.Parameters.AddWithValue("@villainId", villainId);
		int releasedMinions = comm.ExecuteNonQuery();

		// Remove villain from database
		comm = new SqlCommand("DELETE FROM villains WHERE id=@villainId ", conn);
		comm.Parameters.AddWithValue("@villainId", villainId);
		comm.ExecuteNonQuery();

		// Check if transaction is successful
		if (releasedMinions > 0)
		{
			Console.WriteLine($"{villainName} was deleted.");
			Console.WriteLine($"{releasedMinions} minions were released.");
		}
		else
		{
			Console.WriteLine("No changes were made.");
		}
}
```

## 7. All Minion Names
```
var minionNamesList = new List<string>();
using (var conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=minions;Integrated Security=true"))
{
	conn.Open();

	// Get Minions Names and write them to thew List
	SqlCommand command = new SqlCommand("SELECT minions.name FROM minions", conn);
	SqlDataReader reader = command.ExecuteReader();
	while (reader.Read())
	{
		minionNamesList.Add(reader[0].ToString());
	}

	// Print in the given order 
	for (int i = 0; i < minionNamesList.Count() / 2; i++)
	{
		Console.WriteLine(minionNamesList[i]);
		Console.WriteLine(minionNamesList[minionNamesList.Count() - i - 1]);
	}
	if (minionNamesList.Count() % 2 != 0)
	{
		Console.WriteLine(minionNamesList[minionNamesList.Count() / 2 + 1]);
	}
}
```

## 8. Age Increase
```
Console.Write("Enter minions' id: ");
var minionsIds = Console.ReadLine().Split().ToArray();
using (var conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=minions;Integrated Security=true"))
{
	conn.Open();

	// Process All Minnions
	foreach(var minionId in minionsIds)
	{
		// Get Minion Age
		var commandAge = new SqlCommand("SELECT age FROM minions WHERE minions.id = @id", conn);
		commandAge.Parameters.AddWithValue("@id", minionId);
		var minionAge = int.Parse(commandAge.ExecuteScalar().ToString());

		// Select Minion By Id
		var commandName = new SqlCommand("SELECT name FROM minions  where minions.id = @id", conn);
		commandName.Parameters.AddWithValue("@id", minionId);
		var name = commandName.ExecuteScalar().ToString();
		name = name.First().ToString().ToUpper() + name.Substring(1);

		// Update Minion
		var commandUpdate = new SqlCommand("UPDATE minions SET name = @name, age = @age+1 WHERE minions.id = @id", conn);
		commandUpdate.Parameters.AddWithValue("@id", minionId);
		commandUpdate.Parameters.AddWithValue("@age", minionAge);
		commandUpdate.Parameters.AddWithValue("@name", name);
		commandUpdate.ExecuteNonQuery();
	}

	// Print All Minions Names
	SqlCommand commandPrint = new SqlCommand("SELECT name,age FROM minions", conn);
	SqlDataReader reader = commandPrint.ExecuteReader();
	while (reader.Read())
	{
		Console.WriteLine("Name: {0}, Age: {1}", reader[0], reader[1]);
	}

	// CleanUp
	reader.Close();
	conn.Close();
}
```