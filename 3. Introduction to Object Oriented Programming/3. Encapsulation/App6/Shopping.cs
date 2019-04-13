using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App6
{
    class Shopping
    {
        static void Main(string[] args)
        {
            string[] inputPeople = Console.ReadLine().Split(';').ToArray();
            List<Person> people = new List<Person>();
            for (int i = 0; i < inputPeople.Length; i++)
            {
                string[] person = inputPeople[i].Split('=').ToArray();
                people.Add(new Person(person[0], int.Parse(person[1])));
            }

            string[] inputProducts = Console.ReadLine().Split(';').ToArray();
            List<Product> products = new List<Product>();
            for (int i = 0; i < inputProducts.Length; i++)
            {
                string[] product = inputProducts[i].Split('=').ToArray();
                products.Add(new Product(product[0], double.Parse(product[1])));
            }

            string[] command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "END")
            {
                string nameOfPerson = command[0];
                string nameOfProduct = command[1];
                for (int i = 0; i < people.Count; i++)
                {
                    if (people[i].Name == nameOfPerson)
                        people[i].Buy(nameOfProduct, products);
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }

            foreach (var person in people)
            {
                if (person.Products.Count == 0)
                    Console.WriteLine($"{person.Name} - Nothing bought");
                else
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products)}");
            }
        }
    }
}
