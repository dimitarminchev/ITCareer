using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_08
{
/* 8. Трите най-големи числа
Въведете списък от реални числа и изведете 3 най-големи от тях. Ако по-малко от 3 числа съществуват, изведете всички от тях.
Решение: Петко Люцканов
*/
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            nums = nums.OrderByDescending(num => num).Take(3).ToArray();
            Console.Write(string.Join(" ", nums));
        }
    }
}
