using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
/* 4. Изчертаване на запълнен квадрат
Изчертайте на конзолата запълнен квадрат с дължина на страната n.
Решение: Валентин Хаджиминов
 */
    class Program
    {
        static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
        static void PrintMiddleRow(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeaderRow(n);
            PrintMiddleRow(n);
            PrintMiddleRow(n);
            PrintHeaderRow(n);
        }
    }
}
