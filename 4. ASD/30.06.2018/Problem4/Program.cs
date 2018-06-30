using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            // N
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            // 3*N = O(N)
            Console.WriteLine($"Sum={nums.Sum()}; Average={Math.Round(nums.Average()),2}");

            // Total: O(N)
        }
    }
}
