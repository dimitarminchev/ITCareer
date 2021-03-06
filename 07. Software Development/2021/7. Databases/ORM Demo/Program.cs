using System;
using System.Linq;
namespace ORM_Demo
{
    // My data model
    using ORM_Demo.Model;

    class Program
    {
        static void Main(string[] args)
        {
            // Заглавие на конзолното приложение
            Console.WriteLine("ORM Demo 1.0");
            Console.WriteLine(new string('-', 25)); 

            // 1. Контекст на базата данни
            ProductDatabaseContext db = new ProductDatabaseContext();

            // 2. Добавяне на няколко продукта
            db.Products.Add(new Product() { Name = "Beer", Price = 1.2m, Quantity = 25 });
            db.Products.Add(new Product() { Name = "Fries", Price = 2.4m, Quantity = 52 });
            db.Products.Add(new Product() { Name = "Fish", Price = 3.1m, Quantity = 32 });
            db.SaveChanges();

            // 3. Добавяне на поръчка
            db.Orders.Add(new Order() 
            { 
                OrderDate = new DateTime(),  
                Quantity = 5,
                Product = db.Products.FirstOrDefault()
            });
            db.SaveChanges();

            // 4. Извеждане на добавените продукти и поръчки
            foreach (var product in db.Products)
            {
                Console.WriteLine("Name: {0}, Price: {1}, Quantity: {2}",
                product.Name, product.Price, product.Quantity);
            }
            Console.WriteLine("Orders:");
            Console.WriteLine(new string('-', 25));
            foreach (var order in db.Orders)
            {
                Console.WriteLine("Order product: {0}, Quantiti: {1}, Date: {2}",
                order.Product.Name, order.Quantity, order.OrderDate);
            }
        }
    }
}
