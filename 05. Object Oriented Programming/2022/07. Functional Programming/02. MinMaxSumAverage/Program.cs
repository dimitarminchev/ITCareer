using System;
using System.Linq;

namespace _02._MinMaxSumAverage
{
    internal class Program
    {
        /// <summary>
        /// Min Max Sum Average
        /// https://judge.softuni.bg/Contests/Practice/Index/174#2
        /// </summary>
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            // output
            Console.WriteLine("Sum = {0}", nums.Sum());
            Console.WriteLine("Min = {0}", nums.Min());
            Console.WriteLine("Max = {0}", nums.Max());
            Console.WriteLine("Average = {0}", nums.Average());
        }
    }
}