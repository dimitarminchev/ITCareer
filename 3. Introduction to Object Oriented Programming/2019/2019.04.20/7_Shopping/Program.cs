using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            // Persons
            var persons = new List<Person>();
            var cmd = Console.ReadLine().Split(';');
            foreach (var item in cmd)
            {
                var next = item.Split('=');
                persons.Add
                (
                    new Person(next[0], float.Parse(next[1]))
                );
            }

            // Producs
            var products = new List<Product>();
            cmd = Console.ReadLine().Split(';');
            foreach (var item in cmd)
            {
                var next = item.Split('=');
                products.Add
                (
                    new Product(next[0], float.Parse(next[1]))
                );
            }

            // Process Orders
            do
            {
                cmd = Console.ReadLine().Split();
                if (cmd[0] != "END")
                {                    
                    var product = products.FirstOrDefault(x => x.Name == cmd[1]);
                    try
                    {
                        persons.FirstOrDefault(x => x.Name == cmd[0]).AddProduct(product);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            while (cmd[0] != "END");

            // Print
            foreach (var person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
