using System;
using System.Linq;
    
namespace _05._FoldAndSum
{
    internal class Program
    {
        /// <summary>
        /// Fold And Sum
        /// https://judge.softuni.org/Contests/Practice/Index/174#5
        /// </summary>
        static void Main(string[] args)
        {
            // input
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            // process
            int k = nums.Length / 4;
            int[] row1left = nums.Take(k).Reverse().ToArray();
            int[] row1right = nums.Reverse().Take(k).ToArray();
            int[] row1 = row1left.Concat(row1right).ToArray();
            int[] row2 = nums.Skip(k).Take(2 * k).ToArray();
            var sum = row1.Select((x, index) => x + row2[index]);

            // output
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}