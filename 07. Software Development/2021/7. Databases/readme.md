# Свързване на приложения с бази от данни

## 1. Minions Database
```
CREATE TABLE minions (id INT, name VARCHAR(50), age INT);
INSERT INTO minions (id, name, age) VALUES ('1', 'Kevin', '15');
INSERT INTO minions (id, name, age) VALUES ('2', 'Bob', '22')
INSERT INTO minions (id, name, age) VALUES ('3', 'Steward', '42')
SELECT name,age FROM minions;
```

## 2. Microsoft SQL Server
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

## 3. Oracle MySQL Server
1. Създайте MySQL база данни minions 
2. Инсталирайте NuGet пакета MySql.Data
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

## 4. Entity Framework Core 5
Инсталирайте следните NuGet пакети:
```
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.SqlServer
```
Продукт:
```
public class Product
{
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
 }
```
Контекст на базата данни:
```
public class ProductDatabaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ProductDatabaseContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=products; Integrated Security=True");
        }
    }
```
Демонстрационен програмен фрагмент (Program.cs)
```
ProductDatabaseContext db = new ProductDatabaseContext();

db.Products.Add(new Product() { Name = "Beer", Price = 1.2m, Quantity = 42 });
db.Products.Add(new Product() { Name = "Fries", Price = 2.4m, Quantity = 23 });
db.Products.Add(new Product() { Name = "Fish", Price = 3.1m, Quantity = 32 });
db.SaveChanges();

foreach (var product in db.Products)
Console.WriteLine("Name: {0}, Price: {1}", product.Name, product.Price);
```
