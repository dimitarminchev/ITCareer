using System;

namespace Task_13
{
/* 13. Специални числа
Едно  число наричаме специално когато неговата сума от цифри е 5, 7 или 11.
Напишете програма, която въвежда цяло число n и за всички числа в интервала 1 ... n извежда дали числото е специално или не (True / False).
*/
    class Program
    {
        // Решение: Димитър Минчев
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int num = 1; num <= n; num++)
            {
                int sumOfDigits = 0;
                int digits = num;
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
