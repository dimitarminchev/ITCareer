using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Largest3Numbers
{
    internal class Program
    {
        /// <summary>
        /// Largest 3 Numbers
        /// https://judge.softuni.org/Contests/Practice/Index/174#3
        /// </summary>
        static void Main(string[] args)
        {
            // input
            List<int> nums = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToList();

            // processing
            var sortedNums = nums.OrderByDescending(x => x);
            var largest3Nums = sortedNums.Take(3);

            // output
            Console.WriteLine(string.Join(" ", largest3Nums));
        }
    }
}