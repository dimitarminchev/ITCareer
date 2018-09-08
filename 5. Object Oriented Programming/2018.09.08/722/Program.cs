using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _722
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();

            int count = numbers.Count();
            int sum = numbers.Sum();

            Console.WriteLine($"{count}\n{sum}");
        }
    }
}
