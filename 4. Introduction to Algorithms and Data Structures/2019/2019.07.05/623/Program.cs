using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _623
{
    class Program
    {
        // 623 = Recursive Drawing
        private static void PrintFigure(int length)
        {
            int br = length;
            if (length <= 1)
            {
                Console.WriteLine(new string('*', length));
            }
            else
            {
                Console.WriteLine(new string('*', length));
                PrintFigure(length - 1);
            }
            if (br <= length)
            {
                Console.WriteLine(new string('#', length));
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintFigure(n);
        }
    }
}
