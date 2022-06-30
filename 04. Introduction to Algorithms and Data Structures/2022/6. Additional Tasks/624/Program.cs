using System;

namespace _624
{
    public class Program
    {
        /// <summary>
        /// Отпечатване на масив 1/0
        /// </summary>
        private static void Print(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Рекурсивен метод за генериране на 1/0
        /// </summary>
        private static void Gen01(int n, int[] a, int i)
        {
            if (i == n)
            {
                Print(a, n);
                return; // Exit
            }
            a[i] = 0;
            Gen01(n, a, i+1);
            a[i] = 1;
            Gen01(n, a, i+1);
        }

        /// <summary>
        /// Главен метод
        /// </summary>
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Gen01(n, a, 0);
        }
    }
}