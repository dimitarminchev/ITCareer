using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._FilterByAge
{
    internal class Program
    {
        /// <summary>
        /// Filter By Age
        /// https://judge.softuni.org/Contests/Practice/Index/597#4
        /// </summary>
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

            // process and output
            Func<int, bool> tester = CreateTester(condition, age);
            Action<KeyValuePair<string, int>> printer = CreatePrinter(format);
            PrintFilteredStudent(people, tester, printer);
        }

        /// <summary>
        /// Условие за тест
        /// </summary>
        /// <param name="condition">Условие: younger, older</param>
        /// <param name="age">Възраст</param>
        /// <returns></returns>
        public static Func<int, bool> CreateTester(string condition, int age)
        {
            switch (condition)
            {
                case "younger": return x => x < age;
                case "older": return x => x >= age;
                default: return null;
            }
        }

        /// <summary>
        /// Принтер
        /// </summary>
        public static Action<KeyValuePair<string, int>> CreatePrinter(string format)
        {
            switch (format)
            {
                case "name":
                    return person => Console.WriteLine($"{person.Key}");
                case "age":
                    return person => Console.WriteLine($"{person.Value}");
                case "name age":
                    return person =>
                       Console.WriteLine($"{person.Key} - {person.Value}");
                default: return null;
            }
        }

        /// <summary>
        /// Отпечатване на филтрирана колекция
        /// </summary>
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