using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _01.JsonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1. Single Object
            var product = new Product()
            {
                Id = 1,
                Name = "Apple",
                Price = 1.2M,
                Stock = 10,
                Expiry = new DateTime(2019,12,31)
            };

            // Serialize: OOP > JSON
            string jsonObject = JsonConvert.SerializeObject(product);
            Console.WriteLine(jsonObject);


            // Part 2. List of Objects
            List<Product> products = new List<Product>();
            products.Add(new Product()
            {
                Id = 1,
                Name = "Apple",
                Price = 1.2M,
                Stock = 10,
                Expiry = new DateTime(2019, 12, 31)
            });
            products.Add(new Product()
            {
                Id = 2,
                Name = "Tomato",
                Price = 2.1M,
                Stock = 23,
                Expiry = new DateTime(2079, 11, 01)
            });
            products.Add(new Product()
            {
                Id = 3,
                Name = "Lemon",
                Price = 5.78M,
                Stock = 173962,
                Expiry = new DateTime(1991, 10, 12)
            });

            string jsonList = JsonConvert.SerializeObject(products);
            Console.WriteLine(jsonList);

        }
    }
}
