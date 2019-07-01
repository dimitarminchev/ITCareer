using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07
{
/* 7. Сума, минимум, максимум, средноаритметично
Напишете програма, която въвежда n целки числа и извежда тяхната сума, минимум, максимум, първи елемент, последен елемент и средноаритметично.
Решение: Димитър Минчев
*/
    class Program
    {
        static void Main(string[] args)
        {
            // Вход
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++) nums[i] = int.Parse(Console.ReadLine());

            // Изход
            Console.WriteLine("Sum = {0}", nums.Sum());
            Console.WriteLine("Min = {0}", nums.Min());
            Console.WriteLine("Max = {0}", nums.Max());
            Console.WriteLine("Average = {0}", nums.Average());
        }
    }
}
