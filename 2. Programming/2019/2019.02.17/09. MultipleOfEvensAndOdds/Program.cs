using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MultipleOfEvensAndOdds
{
    class Program
    {
        /// <summary>
        /// Сума на четните цифри
        /// </summary>
        private static int GetSumOfEvenDigits(int n)
        {
            n = Math.Abs(n); // fix
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum = sum + lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        /// <summary>
        /// Сума на нечетните цифри
        /// </summary>
        private static int GetSumOfOddDigits(int n)
        {
            n = Math.Abs(n); // fix
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum = sum + lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        /// <summary>
        /// Произведение на сумите на четни и нечетни
        /// </summary>
        private static int GetMultiplePfEvensAndOdds(int n)
        {
            int sumEvens = GetSumOfEvenDigits(n);
            int sumOdds = GetSumOfOddDigits(n);
            return sumEvens * sumOdds;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int product = GetMultiplePfEvensAndOdds(n);
            Console.WriteLine(product);
        }
    }
}
