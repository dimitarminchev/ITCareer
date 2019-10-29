using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
/* 3. Отпечатване на триъгълник
Създайте метод за отпечатване на триъгълници.
Решение: Валентин Хаджиминов
*/
    class Program
    {
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                PrintLine(1, i);
            }
            PrintLine(1, n);
            for (int i = n - 1; i >= 0; i--)
            {
                PrintLine(1, i);
            }
        }
    }
}
