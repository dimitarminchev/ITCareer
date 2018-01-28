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
            var inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rotateTimes = int.Parse(Console.ReadLine());

            var sumArray = new int[inputArray.Length];

            for (int h = 0; h < rotateTimes; h++)
            {
                var temp = inputArray[inputArray.Length - 1];

                for (int i = inputArray.Length - 1; i > 0; i--)
                {
                    inputArray[i] = inputArray[i - 1];
                }

                inputArray[0] = temp;

                for (int i = 0; i < sumArray.Length; i++)
                {
                    sumArray[i] += inputArray[i];
                }
            }

            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
