# Свързване на приложения с бази от данни

## MySQL
```
// Connection String and SQL Query
var connstr = "server=localhost;port=3306;user=root;password=root;database=employees";
var sql = "SELECT dept_name FROM employees.departments;";

// 1. Connection
MySqlConnection connection = new MySqlConnection(connstr);
conn.Open();

// 2. Command
MySqlCommand command = new MySqlCommand(sql, connection);

// 3. Reader
MySqlDataReader reader = command.ExecuteReader();
while (reader.Read()) Console.WriteLine("Name: {0}", reader[0]);

reader.Close();
connection.Close();
```

## ORM
### Първи стъпки в ORM технологиите с Entity Framework (Наков @ БСУ хакатон 2015)
https://nakov.com/blog/2015/05/29/entity-framework-ef-orm-for-beginners/
