using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
{
/* 6. Палиндром
Създайте метод, който получава низ и връща True или False в зависимост от това дали думата е палиндром или не.
Решение: Божидар Андонов
*/
    class Program
    {
        static bool Palindrome(string palindrome)
        {
            bool TrueOrFalse = false;
            for (int i = 0; i <= palindrome.Length / 2; i++)
            {
                if (palindrome[i] != palindrome[palindrome.Length - i - 1])
                {
                    TrueOrFalse = false;
                    break;
                }
                else TrueOrFalse = true;
            }
            return TrueOrFalse;
        }

        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Console.WriteLine(Palindrome(line));
        }
    }
}
