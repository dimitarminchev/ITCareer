using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_16
{
/* 16. Максимална поредица еднакви числа
Въведете списък от цели числа и намерете най-дългата поредица от еднакви елементи. 
Ако съществуват няколко, изпечатайте най-лявата. 
*/
    class Program
    {
        // 	Решение: Божидар Андонов
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int br = 1;
            int best = 1;
            int pos = 0;
            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] == nums[i - 1])
                    br++;
                else br = 1;
                if (br > best)
                {
                    best = br;
                    pos = i - br + 1;
                }
            }
            for (int i = pos; i < best + pos; i++)
                Console.Write($"{nums[i]} ");
            Console.WriteLine();
        }
    }
}
