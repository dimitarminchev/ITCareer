using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SumNumbers
{
    class Program
    {
        // 02. Sum Numbers
        // https://judge.softuni.bg/Contests/Practice/Index/597#1
        static void Main(string[] args)
        {
            // input
            Func<int[]> input = () => Console.ReadLine()
                   .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse).ToArray();

            int[] numbers = input();

            // count
            Func<int[], int> count = (nums) => nums.Count();
            Console.WriteLine(count(numbers));

            // sum
            Func<int[], int> sum = (nums) => nums.Sum();
            Console.WriteLine(sum(numbers));
        }
    }
}
