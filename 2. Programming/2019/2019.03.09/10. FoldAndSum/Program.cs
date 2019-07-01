using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = nums.Count() / 4;

            var left = nums.Take(k).Reverse().ToArray();
            var right = nums.Reverse().Take(k).ToArray();
            var row1 = left.Concat(right).ToArray();
            var row2 = nums.Skip(k).Take(2 * k).ToArray();

            var sum = row1.Select((x, index) => x + row2[index]).ToArray();

            Console.WriteLine(String.Join(" ", sum));
        }
    }
}
