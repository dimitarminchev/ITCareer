using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        /* Problem 1. Принадлежи ли дадено число на масив
            Напишете програма, която чете от конзолата последователност от цели числа на един ред, 
            разделени с интервал и на втори ред число, което се проверява дали съществува в масива 
            от първия ред.  Ако числото съществува в масива, се извежда “{number} Exists in the List”,  
            в противен случай - "{Number} Not exists in the List".
         */
        static void Main(string[] args)
        {
            // O(N^3)
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // O(1)
            int n = int.Parse(Console.ReadLine());
            
            // O(N)
            bool exists = numberExists(n, numbers);

            // O(1)
            if(exists) Console.WriteLine($"{n} Exists in the List"); 
            else Console.WriteLine($"“{n} Not exists in the List");
        }

        // O(N)
        private static bool numberExists(int n, int[] numbers)
        {
            for (int i = 0; i < numbers.Count(); i++)
              if (numbers[i] == n)
                    return true;
            return false;
        }
    }
}
