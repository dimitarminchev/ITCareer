using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.JsonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Сериализиране на обект
            Product product = new Product(1, "Test Product", 100.01m, 100, new DateTime(2019,06,30));
            string json = JsonConvert.SerializeObject(product);
            Console.WriteLine("Single product:");
            Console.WriteLine(json);
            Console.WriteLine(new string('-', 50));

            // 5. Сериализиране на списък от продукти
            List<Product> products = new List<Product>()
            {
                new Product(1, "Milk", 2.59m, 100, new DateTime(2019,06,30)),
                new Product(2, "Lutenitsa", 2.39m, 100, new DateTime(2019,08,30)),
                new Product(3, "Rise", 1.50m, 100, new DateTime(2019,03,30)),
                new Product(4, "Salt", 100.01m, 100, new DateTime(2019,10,30))
            };
            string jsonList = JsonConvert.SerializeObject(products);
            Console.WriteLine("List of products:");
            Console.WriteLine(jsonList);
            Console.WriteLine(new string('-',50));

            // 6. Десериализиране на JSON
            string jsonSizes = @"['Small','Medium','Large','Extra Large']";
            List<string> obj = JsonConvert.DeserializeObject<List<string>>(jsonSizes);
            Console.WriteLine("Deserialize json:");
            Console.WriteLine(string.Join("\n",obj));
            //foreach (var item in obj)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
