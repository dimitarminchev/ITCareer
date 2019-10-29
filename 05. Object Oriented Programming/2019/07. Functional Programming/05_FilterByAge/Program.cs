using System;
using System.Collections.Generic;

namespace _05_FilterByAge
{
    class Program
    {
        public static Func<int, bool> CreateTester(string condition, int age)
        {
            switch (condition)
            {
                case "younger": return x => x < age;
                case "older": return x => x >= age;
                default: return null;
            }
        }

        public static Action<KeyValuePair<string, int>> CreatePrinter(string format)
        {
            switch (format)
            {
                case "name":  return person => Console.WriteLine($"{person.Key}");
                case "age": return person => Console.WriteLine($"{person.Value}");
                case "name age":  return person => Console.WriteLine($"{person.Key} - {person.Value}");
                default: return null;
            }
        }

        private static void PrintFilteredStudent(Dictionary<string, int> people, Func<int, bool> tester, Action<KeyValuePair<string, int>> printer)
        {
            foreach (var person in people)
            {
                if (tester(person.Value))
                {
                    printer(person);
                }
            }
        }

        // 05. Filter By Age
        // https://judge.softuni.bg/Contests/Practice/Index/597#4
        static void Main(string[] args)
        {
            // data structure
            Dictionary<string, int> people = new Dictionary<string, int>();

            // input
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                people.Add(input[0], int.Parse(input[1]));
            }
            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();


            // print
            Func<int, bool> tester = CreateTester(condition, age);
            Action<KeyValuePair<string, int>> printer = CreatePrinter(format);
            PrintFilteredStudent(people, tester, printer);
        }
 
    }
}
