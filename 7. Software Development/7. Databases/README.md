# Свързване на приложения с бази от данни

## Part I. Requirements
- [MySQL Connector .NET](https://dev.mysql.com/downloads/connector/net/)
- [MySQL for Visual Studio](https://dev.mysql.com/downloads/windows/visualstudio/)
- [MySQL Sample Employee Database](https://github.com/datacharmer/test_db)

## Part II. MySQL Connection in Visual Studio 2017
```
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

## part III. Entity Framework and MySQL
NuGet Package Manager Console
```
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package MySql.Data.EntityFrameworkCore
Scaffold-DbContext -Connection "server=localhost;port=3306;user=root;password=root;database=employees" -Provider MySql.Data.EntityFrameworkCore -OutputDir Models
```
Program.cs
```
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

### part IV. Object Relation Mapping (ORM)
Първи стъпки в ORM технологиите с Entity Framework (Светлин Наков @ БСУ Хакатон 2015)
https://nakov.com/blog/2015/05/29/entity-framework-ef-orm-for-beginners/

Microsoft: [DataBase First](https://docs.microsoft.com/en-us/ef/ef6/modeling/designer/workflows/database-first) vs. [Code First](https://docs.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/new-database)
