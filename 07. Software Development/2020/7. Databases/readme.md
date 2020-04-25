# Свързване на приложения с бази от данни

## MySQL

### 1. Инсталирайте пакета MySQL.Data
От менюто на Microsoft Visual Studio изберете следната последователност:
```
Tools > NuGet Package Manager > Package Manager Console
```
Инсталирайте пакета MySql.Database като напишете командата:
```
Install-Package MySql.Data 
```

### 2. Създайте MySQL база данни minions 
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

### 3. Visual Studio връзка с MySQL базата данни 
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

## MSSQL CodeFirst Approach
Примерен контекст:
```
public class ProductContext : DbContext
{
	public DbSet<Product> Products { get; set; }
	public ProductContext()
	{
		Database.EnsureCreated();
	}
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB.;Database=shop; Integrated Security=True");
	}
}
```
От менюто на Microsoft Visual Studio изберете следната последователност:
```
Tools > NuGet Package Manager > Package Manager Console
```
Инсталирайте следните пакети:
```
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Design
Add-Migration InitalCreate
```
