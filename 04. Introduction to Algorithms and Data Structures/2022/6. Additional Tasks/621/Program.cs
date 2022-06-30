using System;

namespace _621
{
    public class Program
    {
        /// <summary>
        /// Рекурсивен метод за намиране на сума
        /// </summary>
        private static int Sum(int[] array, int index)
        {
            int sum = 0;
            if (index <= 0) return 0; // Exit Recursion
            return Sum(array, index - 1) + array[index - 1];
        }

        /// <summary>
        /// Главен метод
        /// </summary>
        public static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(Sum(array, array.Length));
        }
    }
}