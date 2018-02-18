using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
/* 10. Сгъни и сумирай
Въведете масив от 4*k цели числа, сгънете го както е показано по-долу и изведете сумата на горния и долния ред (2*k цели числа).
Решение: Валентин Хаджиминов
*/
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = input.Length / 4;
            int[] row1left = input.Take(k).Reverse().ToArray();
            int[] row1right = input.Reverse().Take(k).ToArray();
            int[] row1 = row1left.Concat(row1right).ToArray();
            int[] row2 = input.Skip(k).Take(2 * k).ToArray();
            var sum = row1.Select((x, index) => x + row2[index]);
            Console.WriteLine(String.Join(" ", sum));
        }
    }
}
