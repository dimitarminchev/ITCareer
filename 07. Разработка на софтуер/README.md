# Модул 7. Разработка на софтуер
[Материали](07.%20Разработка%20на%20софтуер.%20Материали.zip) |
[Задачи](07.%20Разработка%20на%20софтуер.%20Задачи.pdf) |
[Решения](07.%20Разработка%20на%20софтуер.%20Решения.zip) | 
[Видео](https://youtube.com/playlist?list=PL-w_n7hgFuN3G1L_3Tc38F7mZRbMb-Al4) 

## Съдържание
1. [Увод в разработката на софтуер. Преглед на трислойния модел](1.%20MVC/)
2. [Увод в концепцията за тестване. Писане на компонентни тестове](2.%20Unit%20Tests/)
3. [Увод в концепцията за дебъгване. Откриване и отстраняване на проблеми](3.%20Debugging/)
4. [Преработка на кода и постепенни промени](4.%20Refactoring/)
5. [Инструменти за разработка](5.%20IDE/)
6. [Пакети и външни библиотеки](6.%20NuGet/)
7. [Свързване на приложения с бази от данни](7.%20Databases/)
8. [Създаване на приложения с няколко потребителски интерфейса](8.%20UI/)

## Компонентнo тестване
![Vidual Studio Code Coverage](2.%20Unit%20Tests/UnitTests.png)

Анализ покритието на кода с тестове:
```
Test > Analize Code Coverage for All Tests
```
Requires: Microsoft Visual Studio Enterprise Edition.

![Vidual Studio Code Coverage](2.%20Unit%20Tests/CodeCoverage.png)

## Преработка на кода

### Класове и структури
Нотация:
- PascalCase 

Правила:
```
[Съществително] 
[Прилагателно] + [Съществително]
```

Примери:
Student, FileSystem, BinaryTreeNode, Constants, MathUtils, CheckBox, Calendar

### Интерфейси
Правила:
```
'I' + [Глагол] + 'able'
'I' + [Съществително], 'I' + [Прилагателно] + [Съществително]
```
Примери:
- IEnumerable, IFormattable, IDataReader, IList, IHttpModule, ICommandExecutor

### Изброими типове
Правила:
```
[Съществително] 
[Глагол] 
[Прилагателно]
```

Примери:
enum Day { Monday, Tuesday, Wednesday, ... }

### Методи
Нотация:
- PascalCase 

Правила:
```
[Глагол], [Глагол] + [Съществително]
[Глагол] + [Прилагателно] + [Съществително]
```

Примери:
Show, LoadSettingsFile, FindNodeByPattern, ToString, PrintList

### Променливи
Нотация:
- camelCase  

Правила:
```
[Съществително]
[Прилагателно]
[Съществително]
```

Примери:
firstName,  usersList, fontSize, maxSpeed, startIndex, endIndex, charsCount, databaseConnection, createUserSqlCommand

### Документация

#### Step 1. Install
- [Microsoft HTML Help Workshop 1.3](https://www.helpandmanual.com/download/htmlhelp.exe)
- [Sandcastle Help File Builder](https://github.com/EWSoftware/SHFB/releases/)

#### Step 2. Visual Studio
```
Project > Properties > Build > Output > Documentation File > Generate a file containing API documentation. 
Build > Build Solution
```

#### Step 3. Generate
![Sandcastle](4.%20Refactoring/Sandcastle.png)

## Интегрирана среда за разработка

| **Кодова дума** | **Действие** |
| --- | --- |
| class | Създава декларация на клас |
| ctor | Създава декларация на конструктор |
| cw | Console.WriteLine(); |
| do | Създава do…while цикъл |
| if | Създава if проверка |
| else | Добавя else към if проверка |
| exception | Създава клас, който наследява от Exception |
| for | for (int i = 0; i \&lt; length; i++) |
| foreach | foreach (var item in collection) |
| forr | for (int i = length - 1; i \&gt;= 0; i--) |
| interface | Създава декларация на интерфейс |
| prop | public int MyProperty { get; set; } |
| propfull | Създава поле + свойство свързано с него |
| switch | Създава switch блок |
| try | Създава try-catch блок |
| while | Създава while цикъл |

## Пакети и външни библиотеки

### JSON
- [JavaScript Object Notation](https://www.json.org/json-bg.html)
- [Chuck Norris JSON Api](https://api.chucknorris.io/)
- [JSON Online Viewer](http://jsonviewer.stack.hu/)
- [Convert Json 2 Csharp](https://json2csharp.com/)
- [Json.NET](https://www.newtonsoft.com/json)

#### 1. Sample Chuck Norris joke in JSON format
```json
{
    "categories":[],
    "created_at":"2020-01-05 13:42:30.730109",
    "icon_url":"https://assets.chucknorris.host/img/avatar/chuck-norris.png",
    "id":"kMGfjmcYTuqewbR6DpvwDg","updated_at":"2020-01-05 13:42:30.730109",
    "url":"https://api.chucknorris.io/jokes/kMGfjmcYTuqewbR6DpvwDg",
    "value":"Chuck Norris taught birds how to fly"
}
```
#### 2. Sample JSON to C# Class
```cs
public class Joke
{
    public List<object> categories { get; set; }
    public string created_at { get; set; }
    public string icon_url { get; set; }
    public string id { get; set; }
    public string updated_at { get; set; }
    public string url { get; set; }
    public string value { get; set; }
}
```
#### 3. Deserialize JSON to Object
```
var obj = JsonConvert.DeserializeObject<Joke>(json);
```
#### 4. Serialize Object to JSON
```
var json  = JsonConvert.SerializeObject(obj);
```

## Свързване с бази от данни

### MSSQL
1. Създайте MSSQL база данни minions 
2. Инсталирайте NuGet пакета **System.Data.SqlClient**
3. Демонстрационен програмен фрагмент **Program.cs**
```cs
SqlConnection conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=minions;Integrated Security=true");
conn.Open();
using (conn)
{
	SqlCommand command = new SqlCommand("SELECT name,age FROM minions;", conn);
	SqlDataReader reader = command.ExecuteReader();
	while (reader.Read()) Console.WriteLine("Name: {0}, Age: {1}", reader[0], reader[1]);
}
```

#### 1. Minions Database
```sql
USE [minions];

-- Create table
CREATE TABLE [minions] 
(
	[id] INT, 
	[name] VARCHAR(50), 
	[age] INT
);

-- Inser Data
INSERT INTO [minions] ([id], [name], [age]) VALUES ('1', 'Kevin', '15');
INSERT INTO [minions] ([id], [name], [age]) VALUES ('2', 'Bob', '22');
INSERT INTO [minions] ([id], [name], [age]) VALUES ('3', 'Steward', '42');

-- Select
SELECT [name],[age] FROM [minions];
```

#### 2. Villians Names
```cs
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

#### 3. Minions Names
```cs
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

#### 4. Add Minion
```cs
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

#### 5. Change Register
```cs
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

#### 6. Remove Villian
```cs
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

#### 7. All Minion Names
```cs
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

#### 8. Age Increase
```cs
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

### MySQL
- [MySQL Connector .NET](https://dev.mysql.com/downloads/connector/net/)
- [MySQL for Visual Studio](https://dev.mysql.com/downloads/windows/visualstudio/)
- [MySQL Sample Employee Database](https://github.com/datacharmer/test_db)

#### MySQL Connection in Visual Studio 
```cs
// Connection String and SQL Query
var connstr = "server=localhost;port=3306;user=root;password=root;database=employees";
var sql = "SELECT dept_name FROM employees.departments;";

// Connection
MySqlConnection connection = new MySqlConnection(connstr);
conn.Open();

// Command
MySqlCommand command = new MySqlCommand(sql, connection);

// Reader
MySqlDataReader reader = command.ExecuteReader();
while (reader.Read()) Console.WriteLine("Name: {0}", reader[0]);

reader.Close();
connection.Close();
```

#### Entity Framework and MySQL
NuGet Package Manager Console
```
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package MySql.Data.EntityFrameworkCore
Scaffold-DbContext -Connection "server=localhost;port=3306;user=root;password=root;database=employees" -Provider MySql.Data.EntityFrameworkCore -OutputDir Models
```
Program.cs
```cs
var context = new employeesContext();
{
	// select
	foreach (var department in context.Departments)
	Console.WriteLine(department.DeptName);
}
{
	// update
	var department = context.Departments.FirstOrDefault(d => d.DeptNo == "d002");
	department.DeptName = "Money"; // Finances => Money
	context.SaveChanges();
}
{
	// delete
	var department = context.Departments.FirstOrDefault(d => d.DeptNo == "d002");
	context.Departments.Remove(department);
	context.SaveChanges();
}
```

### Object Relation Mapping (ORM)
- Microsoft: [DataBase First](https://docs.microsoft.com/en-us/ef/ef6/modeling/designer/workflows/database-first) vs. [Code First](https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/new-database)
- [Първи стъпки в ORM технологиите с Entity Framework](https://nakov.com/blog/2015/05/29/entity-framework-ef-orm-for-beginners/). Светлин Наков @ БСУ Хакатон 2015.

## Потребителски интерфейси
1. Install [Microsoft SQL Server Express Edition](https://www.microsoft.com/en-us/sql-server/sql-server-editions-express)
2. Install [Microsoft SQL Server Management Studio](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)
3. Locate your connection string
```
Data Source=localhost\SQLEXPRESS; Initial Catalog=shop; Integrated Security=SSPI
```
4. Update Connection String in Files
- [Data/ProductContext.cs](8.%20UI/Data/ProductContext.cs)
- [UWPApp/Model/Products.cs](8.%20UI/UWPApp/Model/Products.cs)

5. Create Sample Database
```sql
-- Drop Database
DROP DATABASE IF EXISTS [products];
GO

-- Create Database
CREATE DATABASE [shop];
GO

-- Use Dataase
USE [products];
GO

-- Create Table
CREATE TABLE [products]
(
	Id INT IDENTITY PRIMARY KEY,
	Name VARCHAR(100) NOT NULL,
	Price DECIMAL(10,2),
	Stock INT
);
GO

-- Insert Data
INSERT INTO [products] ([Name],[Price],[Stock]) VALUES 
('Beer',1.2,10),
('Fries',2.4,5),
('Fish',3.1,4),
('Coke',2.6,3),
('Hamurger',4.2,2);
GO
```