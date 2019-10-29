using System;
using System.Linq;

namespace _3_OldestMembeр
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
                family.AddMember
                (
                    new Person()
                    {
                        Name = line[0],
                        Age = int.Parse(line[1])
                    }
                );
                n--;
            }

            // Print
            Person oldestPerson = family.GetOldestMember();
            Console.WriteLine(oldestPerson.ToString() );
        }
    }
}
