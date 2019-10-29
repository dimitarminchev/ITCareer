using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15
{
/* 15. Списък от крайности
Въведете списък от цели числа и изведете тези от тях, които са равни на минималния или максималния елемент.
*/
    class Program
    {
        // Решение: Божидар Андонов
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var max = nums[0];
            var min = nums[0];
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > max) max = nums[i];
                if (nums[i] < min) min = nums[i];
            }
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == max || nums[i] == min) Console.Write($"{nums[i]} ");
            }
        }
    }
}
