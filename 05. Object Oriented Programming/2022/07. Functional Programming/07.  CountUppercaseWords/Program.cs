using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.__CountUppercaseWords
{
    internal class Program
    {
        /// <summary>
        /// Count Uppercase Words
        /// https://judge.softuni.org/Contests/Practice/Index/597#2
        /// </summary>
        static void Main(string[] args)
        {
            // input
            var words = Console.ReadLine()
                        .Split(new string[] { " " },
                        StringSplitOptions.RemoveEmptyEntries);

            // processing
            Func<string, bool> checker = n => n[0] == n.ToUpper()[0];

            // output
            words.Where(checker)
                 .ToList()
                 .ForEach(n => Console.WriteLine(n));

        }
    }
}