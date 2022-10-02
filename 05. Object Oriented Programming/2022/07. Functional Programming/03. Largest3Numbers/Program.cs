using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Largest3Numbers
{
    internal class Program
    {
        // Largest 3 Numbers
        // https://judge.softuni.org/Contests/Practice/Index/174#3
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToList();

            var sortedNums = nums.OrderByDescending(x => x);

            var largest3Nums = sortedNums.Take(3);

            Console.WriteLine(string.Join(" ", largest3Nums));
        }
    }
}