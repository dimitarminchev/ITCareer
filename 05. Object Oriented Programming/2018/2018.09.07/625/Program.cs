using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _625
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Person> sortByName = new SortedSet<Person>(new NameComparator());
            HashSet<Person> sortByAge = new HashSet<Person>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split().ToArray();
                bool unique = true;
                Person personToCompareWith = new Person(line[0], int.Parse(line[1]));
                foreach(var person in sortByName)
                {
                    if(person.Equals(personToCompareWith))
                        unique = false;
                }
                if (unique) sortByName.Add(personToCompareWith);

                unique = true;
                foreach(var person in sortByAge)
                {
                    if(person.GetHashCode() == personToCompareWith.GetHashCode())
                        unique = false;
                }

                if (unique) sortByAge.Add(personToCompareWith);
            }

            Console.WriteLine(sortByName.Count);
            Console.WriteLine(sortByAge.Count);
        }
    }
}
