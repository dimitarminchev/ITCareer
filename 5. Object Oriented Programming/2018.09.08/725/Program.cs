using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _725
{
    class Program
    {
        private static void Main(string[] args)
        {
            Dictionary<string, int> people = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                people.Add(line[0], int.Parse(line[1]));
            }
            var condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            var format = "name age";

            Func<int, bool> tester = CreateTester(condition, age);
            Action<KeyValuePair<string, int>> printer = CreatePrinter(format);
            PrintFilteredStudent(people, tester, printer);
        }

        public static Action<KeyValuePair<string, int>> CreatePrinter(string format)
        {
            switch (format)
            {
                case "name": return person => Console.WriteLine($"{person.Key}");
                case "age": return person => Console.WriteLine($"{person.Value}");
                case "name age": return person => Console.WriteLine($"{person.Key} - {person.Value}");
                default: return null;
            }
        }

        public static Func<int, bool> CreateTester(string condition, int age)
        {
            switch (condition)
            {
                case "younger": return x => x < age;
                case "older": return x => x >= age;
                default: return null;
            }
        }

        public static void PrintFilteredStudent
        (
            Dictionary<string, int> people, 
            Func<int, bool> tester, 
            Action<KeyValuePair<string, int>> printer
        )
        {
            foreach (var person in people)
            {
                if (tester(person.Value))
                {
                    printer(person);
                }
            }
        }



    }
}
