using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
/* 1. Статистика на масив 
Напишете програма, която получава масив от цели числа (разделени  с интервал) и извежда най-малкия елемент, 
най-големия елемент, сумата на елементите и средната им стойност.
*/
    class Program
    {
        // Решение: Владимир Владимиров
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double min = 1000, max = -1000, sum = 0;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                sum = sum + arr[i];
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(sum);
            Console.WriteLine(sum / n);
        }
    }
}
