using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.SpecialNumbers
{
    class Program
    {
        // 13. Специални Числа
        static void Main(string[] args)
        {
            //  Брой на специалните числа
            int n = int.Parse(Console.ReadLine());

            // Циклъ за обхождането им
            for (int num = 1; num <= n; num++)
            {
                int sumOfDigits = 0; // сума на цифрите
                int digits = num; // цифра
                while (digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;
                }
                bool special = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine("{0} -> {1}", num, special);
            }

        }
    }
}
