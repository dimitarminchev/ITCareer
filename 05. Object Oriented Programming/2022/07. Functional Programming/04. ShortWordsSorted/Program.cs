using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._ShortWordsSorted
{
    internal class Program
    {
        /// <summary>
        /// Short Words Sorter
        /// https://judge.softuni.org/Contests/Practice/Index/174#4
        /// </summary>
        static void Main(string[] args)
        {
            char[] separators = new char[]{'.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' '};

            string sentence = Console.ReadLine().ToLower();

            string[] words = sentence.Split(separators);

            var result = words
                      .Where(w => w != "")
                      .Where(w => w.Count() < 5)
                      .OrderBy(w => w).Distinct();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}