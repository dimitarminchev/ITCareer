using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        /* Problem 4. Сбор и Средно аритметично
            Напишете програма, която чете от конзолата последователност от числа (на един ред, разделени с интервал). 
            Изчислява и отпечатате сбора и средната стойност на елементите на последователността. 
            Запазва последователността в List<int>. 
            Закръглете средната стойност до втората цифра след десетичния разделител.
         */
        static void Main(string[] args)
        {
            // N
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            // 3*N = O(N)
            Console.WriteLine($"Sum={nums.Sum()}; Average={Math.Round(nums.Average()),2}");

            // Total: O(N)
        }
    }
}
