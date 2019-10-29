using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            // Добавяме случаен брой хора към колекцията
            Random r = new Random();
            int random = r.Next(100);
            for (int i = 0; i < random; i++)
            {
                persons.Add(new Person(i.ToString(), i));
            }

            // Колко сме добавили?
            Console.WriteLine("Persons Counter = {0}", Person.Count);
  
        }
    }
}
