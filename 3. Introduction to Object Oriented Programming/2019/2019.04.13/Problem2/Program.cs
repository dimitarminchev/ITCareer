using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            // Input
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                var line = Console.ReadLine().Split().ToArray();
                family.Persons.Add
                (
                    new Person()
                    {
                        Name = line[0],
                        Age = int.Parse(line[1])
                    }
                );
                n--;
            }

            // Sort
            family.Persons = family.Persons.OrderBy(person => person.Name).ToList();

            // Print
            family.Print();
        }
    }
}
