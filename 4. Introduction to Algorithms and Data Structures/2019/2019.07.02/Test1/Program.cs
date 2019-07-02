using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void PrintFigure(int n)
        {
            // Bottom of the recursion
            if (n == 0) return;

            // предварително действие: отпечатва n звездички
            Console.WriteLine(new string('*', n));

            // рекурсивно извикване: отпечатва фигура с размер n-1
            PrintFigure(n - 1);

            // последващо действие: отпечатва n хештаг-а # (диез)
            Console.WriteLine(new string('#', n));
        }


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintFigure(n);
        }
    }
}
