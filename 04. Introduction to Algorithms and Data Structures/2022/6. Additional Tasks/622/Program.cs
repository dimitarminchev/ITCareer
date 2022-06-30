using System;

namespace _622
{
    public class Program
    {
        /// <summary>
        /// Рекурсивен метод за намиране на факториел
        /// </summary>
        private static long Fak(int n)
        {
            if (n <= 0) return 1; // Exit Recurtion
            else return n * Fak(n - 1);
        }

        /// <summary>
        /// Главен метод
        /// </summary>
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fak(n));
        }
    }
}