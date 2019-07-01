using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Програма демонстрираща бързо намиране на квадратен корен
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                var value = SquareRootPrecalculator.GetSqrt(number);
                Console.WriteLine(value);
            }
        }
    }
}
