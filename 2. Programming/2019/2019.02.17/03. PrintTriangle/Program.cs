using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrintTriangle
{
    // 03. Отпечатване на триъгълник
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

        static void PrintTriangle(int n)
        {
            for (int line = 1; line <= n; line++)
                PrintLine(1, line);

            for (int line = n - 1; line >= 1; line--)
                PrintLine(1, line);
        }

        static void Main(string[] args)
        {
            PrintTriangle(int.Parse(Console.ReadLine()));
        }
    }
}
