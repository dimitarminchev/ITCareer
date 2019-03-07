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
