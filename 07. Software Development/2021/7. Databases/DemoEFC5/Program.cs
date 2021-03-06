using System;
using System.Linq;

namespace DemoEFC5
{
    // My data model
    using DemoEFC5.Model;

    class Program
    {
        static void Main(string[] args)
        {
            // Заглавие на конзолното приложение
            Console.WriteLine("Entity Framework Core 5");

            // 1. Контекст на базата данни
            ProductDatabaseContext db = new ProductDatabaseContext();

            // 2. Добавяне на продукти
            db.Products.Add(new Product() { Name = "Beer", Price = 1.2m, Quantity = 42 });
            db.Products.Add(new Product() { Name = "Fries", Price = 2.4m, Quantity = 23 });
            db.Products.Add(new Product() { Name = "Fish", Price = 3.1m, Quantity = 32 });
            db.SaveChanges();


            // 2. Извеждане на добавените продукти 
            Console.WriteLine();
            Console.WriteLine("Products:");
            Console.WriteLine(new string('-', 25));
            foreach (var product in db.Products)
            {
                Console.WriteLine("Name: {0}, Price: {1}, Quantity: {2}",
                product.Name, product.Price, product.Quantity);
            }

            // 3. Добавяне на поръчка
            db.Orders.Add(new Order() 
            { 
                OrderDate = DateTime.Now,  
                Quantity = 5,
                Product = db.Products.FirstOrDefault()
            });
            db.SaveChanges();

            // 4. Извеждане на добавените поръчки
            Console.WriteLine();
            Console.WriteLine("Orders:");
            Console.WriteLine(new string('-', 25));
            foreach (var order in db.Orders)
            {
                Console.WriteLine("Product: {0}, Quantity: {1}, Date: {2}",
                order.Product.Name, order.Quantity, order.OrderDate);
            }
        }
    }
}
