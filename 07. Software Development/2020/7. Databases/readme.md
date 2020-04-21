# Свързване на приложения с бази от данни
- [MySQL Connector .NET](https://dev.mysql.com/downloads/connector/net/)
- [MySQL for Visual Studio](https://dev.mysql.com/downloads/windows/visualstudio/)

## Minions Database
```
CREATE SCHEMA IF NOT EXISTS `minions`;
CREATE TABLE IF NOT EXISTS `minions`.`minions` 
(
  id INT NOT NULL,
  name VARCHAR(50) NOT NULL,
  age INT(3) NULL,
  PRIMARY KEY (id)
);
INSERT INTO minions.minions (id, name, age) VALUES ('1', 'Kevin', '15');
INSERT INTO minions.minions (id, name, age) VALUES ('2', 'Bob', '22');
INSERT INTO minions.minions (id, name, age) VALUES ('3', 'Steward','42');
```

##  MySQL Connection in Visual Studio 
```
// 1. Connection String
var connstr = "server=localhost;port=3306;user=root;password=root;database=minions";

// 2. MySQL Connection
MySqlConnection conn = new MySqlConnection(connstr);
conn.Open();

// 3. SQL Query
var sql = "SELECT name,age FROM minions;";

// 4. MySQL Command
MySqlCommand command = new MySqlCommand(sql, conn);

// 5. MySQL Reader
MySqlDataReader reader = command.ExecuteReader();
while (reader.Read())
{
	Console.WriteLine("Name: {0}, Age: {1}", reader[0], reader[1]);
}

// 6. Close MySQL Reader and Connection
reader.Close();
conn.Close();
```