using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        // 30. Цифри 
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var a1 = (a / 100) % 10;
            var a2 = (a / 10) % 10;
            var a3 = (a / 1) % 10;
            for (int n = 0; n < a1+a2; n++)
            {
                for (int m = 0; m < a1+a3; m++)
                {
                    if (a % 5 == 0) a -= a1;
                    else if (a % 3 == 0) a -= a2;
                    else a += a3;
                    Console.Write("{0} ", a);
                }
                Console.WriteLine();
            }
        }
    }
}
