using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_LCM
{
    class Program
    {
        // Least Common Multiple (LCM)

        public static int LCM(int a, int b)
        {
            return a * (b / GCD(a, b));
        }

        // Greatest Common Divisor (GCD)
        public static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        static void Main(string[] args)
        {
            int a = 35, b = 14;
            int lcm = LCM(a, b);
            Console.WriteLine(lcm);
        }
    }
}
