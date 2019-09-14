using System;
using System.Linq;

namespace _03_CountUppercaseWords
{
    class Program
    {
        // 03. Count Uppercase Words
        // https://judge.softuni.bg/Contests/Practice/Index/597#2
        static void Main(string[] args)
        {
            // input
            var words = Console.ReadLine().Split(new string[] { " " },
                 StringSplitOptions.RemoveEmptyEntries);

            // delegate
            Func<string, bool> checker = n => n[0] == n.ToUpper()[0];

            // iyutput
            words.Where(checker)
                 .ToList()
                 .ForEach(n => Console.WriteLine(n));
        }
    }
}
