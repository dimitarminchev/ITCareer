using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ReverseAndSum
{
    class Program
    {
        // 7. Завъртане и сумиране
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            // Обработка
            int[] sum = new int[nums.Length];
            while (k > 0)
            {
                nums = Rotate(nums);
                sum = Sum(sum, nums);
                k--;
            }
            Console.WriteLine(string.Join(" ", sum));
        }

        // Въртене
        static int[] Rotate(int[] nums)
        {
            var part1 = nums.Take(nums.Length - 1).ToArray();
            var part2 = nums.Skip(nums.Length - 1).Take(1).ToArray();
            return part2.Concat(part1).ToArray();
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
