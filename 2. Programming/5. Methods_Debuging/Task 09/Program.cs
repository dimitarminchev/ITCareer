using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09
{
/* 9. Умножаване на четни по нечетни
Създайте програма, която прочита цяло число и умножава сумата на всичките му нечетни цифри по сумата на всичките му четни цифри.
Решение: Деислава Зоин
*/
    class Program
    {
        static int GetMultipleOfBoth(int n)
        {
            int sumEvens = GetSumOfEvens(n);
            int sumOdds = GetSumOfOdds(n);
            return sumEvens * sumOdds;
        }

        static int GetSumOfEvens(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastdigit = n % 10;
                if (n % 2 == 0) sum += lastdigit;
                n = n / 10;
            }
            return sum;
        }

        static int GetSumOfOdds(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastdigit = n % 10;
                if (n % 2 != 0) sum += lastdigit;
                n = n / 10;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfBoth(Math.Abs(n)));
        }
    }
}
