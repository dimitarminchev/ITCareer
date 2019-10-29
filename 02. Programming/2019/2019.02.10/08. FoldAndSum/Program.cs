using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.FoldAndSum
{
    class Program
    {
        // 8. Сгъни и събери
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            nums = Fold(nums);
            Console.WriteLine(string.Join(" ", nums));
        }

        // Сгъване
        static int[] Fold(int[] nums)
        {
            var part1 = nums.Take(nums.Length / 4).ToArray();
            var part2 = nums.Skip(nums.Length / 4).Take(nums.Length / 2).ToArray();
            var part3 = nums.Skip(nums.Length * 3/4).Take(nums.Length / 4).ToArray();

            var a = (part1.Reverse()).Concat(part3.Reverse()).ToArray();
            var b = part2;

            return Sum(a,b);
        }

        // Сумиране
        static int[] Sum(int[] a, int[] b)
        {
            var sum = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                sum[i] = a[i] + b[i];
            return sum;
        }
    }
}
