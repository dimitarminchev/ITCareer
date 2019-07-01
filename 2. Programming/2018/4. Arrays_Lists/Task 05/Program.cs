using System;

namespace Task_05
{
/* 5. Обръщане на последователността на елементите на масив 
Напишете програма, която въвежда масив от цели числа, Обръща го и извежа елементите. Входните данни са  числото n (брой на елементите) + n цели числа, всяко на отделен ред. Изведете резултата на един ред, за разделител да се ползва интервал.
*/
    class Program
    {
        // Решение: Живко Колев
        static void Main(string[] args)
        {
            int[] num = new int[100];
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
                num[i] = int.Parse(Console.ReadLine());

            for (int i = n - 1; i >= 0; i--)
                Console.Write("{0} ", num[i]);
        }
    }
}
