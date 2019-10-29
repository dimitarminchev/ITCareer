using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
/* 2. Знак на цяло число
Създайте метод, отпечатващ знака на цяло число n.
Решение: Петко Люцканов
*/
    class Program
    {
        static void PrintSign(int number)
        {
            if (number == 0) Console.WriteLine("The number {0} is zero.", number);
            else if (number > 0) Console.WriteLine("The number {0} is positive.", number);
            else Console.WriteLine("The number {0} is negative.", number);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }
    }
}
