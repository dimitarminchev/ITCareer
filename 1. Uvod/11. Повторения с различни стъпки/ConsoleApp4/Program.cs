using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Четни степени на 2
            int n = int.Parse(Console.ReadLine());
            int step2 = 1;
            while (n >= 0)
            {
                Console.WriteLine(step2);
                step2 *= 4;
                n-=2;
            }
        }
    }
}
