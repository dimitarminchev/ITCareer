using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6. Най-малко число
            var n = long.Parse(Console.ReadLine());
            long min = +10000000000000;
            for (int i = 0; i < n; i++)
            {
                var k = long.Parse(Console.ReadLine());
                if (k < min) min = k;
            }
            Console.WriteLine(min);
        }
    }
}
