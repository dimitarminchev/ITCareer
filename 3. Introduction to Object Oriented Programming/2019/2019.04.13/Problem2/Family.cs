using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Family
    {
        // Списък от хора
        private List<Person> persons = new List<Person>();

        public List<Person> Persons
        {
            get { return persons; }
            set { persons = value; }
        }

        // Метод който отпечатва хората от списъка
        public void Print()
        {
            foreach (var person in Persons)
            {
                Console.WriteLine("Name {0}, Age {1}", person.Name, person.Age);
            }
        }


    }
}
