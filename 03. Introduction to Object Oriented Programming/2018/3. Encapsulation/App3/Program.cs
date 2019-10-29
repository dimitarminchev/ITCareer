using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Колекция 
            var persons = new List<Person>();

            // Вход
            var lines = int.Parse(Console.ReadLine());            
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), double.Parse(cmdArgs[3]));
                persons.Add(person);
            }

            // Добавяне на Бонус
            var bonus = double.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(bonus));

            // Изход
            persons.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
