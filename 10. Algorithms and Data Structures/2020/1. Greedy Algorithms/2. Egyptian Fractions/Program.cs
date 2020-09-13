using System;

namespace _2._Egyptian_Fractions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Дроб: 7/9
            int p = 7, q = 9, r = 0;

            while (p > 1)
            {
                r = (p + q) / p; // r=(7+9)/7=2
                Console.Write("1/{0} + ", r);

                // Общ знаменател
                p = p * r - q; // p = 7*2-9 = 5
                q = q * r; // q = 9*2 = 18

                // Съкращение с НОД
                int m = gcd(p, q);
                p = p / m;
                q = q / m;
            }
            Console.Write("1/{0}", q);
        }

        // Greatest common divisor
        private static int gcd(int a, int b)
        {
            if (a > b) return gcd(a - b, b);
            else if (b > a) return gcd(a, b - a);
            return a;
        }
    }
}
