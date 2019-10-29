using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> family = new List<Person>();

            // Input
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                var line = Console.ReadLine().Split().ToArray();
                family.Add
                (
                    new Person()
                    {
                        Name = line[0],
                        Age = int.Parse(line[1])
                    }
                );
                n--;
            }

            // Process and Print
            family = family.Where(person => person.Age > 30).ToList(); // >30
            family = family.OrderBy(person => person.Name).ToList(); // sort

            // Print
            foreach (var person in family)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

        }
    }
}
