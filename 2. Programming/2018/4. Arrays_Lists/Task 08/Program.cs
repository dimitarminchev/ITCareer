using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_08
{
/* 8. Сгъни и събери 
Въведете масив от  4*k  цели числа, сгънете го както е указано по-долу и изведете сумата на горния и долния ред (всеки, съдържащ 2 * k  цели числа):
*/
    class Program
    {
        // Решение: Митко Недялков
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var row1Part1 = new int[numbers.Length / 4];
            var row1Part2 = new int[numbers.Length / 4];
            var row2 = new int[numbers.Length / 2];

            for (int i = 0; i < numbers.Length / 4; i++)
            {
                row1Part2[i] = numbers[numbers.Length - 1 - i];
            }

            for (int i = 0; i < numbers.Length / 4; i++)
            {
                row1Part1[i] = numbers[i];
            }

            row1Part1 = row1Part1.Reverse().ToArray();

            var row1 = new int[row1Part1.Length + row1Part2.Length];

            for (int i = 0; i < row1.Length / 2; i++)
            {
                row1[i] = row1Part1[i];
            }

            for (int i = 0; i < row1.Length / 2; i++)
            {
                row1[i + row1Part1.Length] = row1Part2[i];
            }

            for (int i = numbers.Length / 4; i < numbers.Length / 2 + numbers.Length / 4; i++)
            {
                row2[i - numbers.Length / 4] = numbers[i];
            }

            for (int i = 0; i < row1.Length; i++)
            {
                Console.Write("{0} ", row1[i] + row2[i]);
            }
        }
    }
}
