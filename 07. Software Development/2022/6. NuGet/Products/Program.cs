using System;
using Newtonsoft.Json;

namespace Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 4. Create Single Product
            Product product = new Product()
            {
                Id = 1,
                Name = "Test product",
                Price = 100.01m,
                Stock = 100,
                Expiry = new DateTime(2019, 06, 30)
            };
            string json = JsonConvert.SerializeObject(product);
            Console.WriteLine("Task 4. Create Single Product");
            Console.WriteLine(json);
            Console.WriteLine(new string('-', 50));

            // Task 5. Create List of Products
            List<Product> products = new List<Product>()
            {
                new Product(1 ,"Milk", 2.59m, 100, new DateTime(2019, 06, 30)),
                new Product(2 ,"Lyutenitsa", 2.39m, 100, new DateTime(2019, 08, 30)),
                new Product(3 ,"Rice", 1.50m, 100, new DateTime(2020, 03, 30)),
                new Product(4 ,"Salt", 100.01m, 100, new DateTime(2019, 10, 30)),
            };
            string jsonList = JsonConvert.SerializeObject(products);
            Console.WriteLine("Task 5. Create List of Products");
            Console.WriteLine(jsonList);
            Console.WriteLine(new string('-', 50));

            // Task 6. Deserialize List of JSON
            string jsonSizes = @"['Small','Medium','Large']";
            var objectSizes = JsonConvert.DeserializeObject(jsonSizes);
            Console.WriteLine("Task 6. Deserialize List of JSON");
            Console.WriteLine(string.Join(' ', objectSizes));
        }
    }
}