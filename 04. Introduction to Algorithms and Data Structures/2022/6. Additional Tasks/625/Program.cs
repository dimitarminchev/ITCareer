using System;

namespace _625
{
    public class Program
    {
        // Входни данни
        private static int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        private static int n = int.Parse(Console.ReadLine());
        private static int[] loops = new int[n];

        /// <summary>
        /// Рекурсивен метод за генериране на комбинации
        /// </summary>
        private static void Combinations(int index, int[] array, int border = 0)
        {
            if (index == loops.Length)
            {
                Console.WriteLine(String.Join(" ", loops));
                return; // Exit
            }
            for (int i = border; i < array.Length; i++)
            {
                loops[index] = array[i];
                Combinations(index + 1, array, i + 1);
            }
        }

        /// <summary>
        /// Главен метод
        /// </summary>
        public static void Main(string[] args)
        {
            Combinations(0, array);
        }
    }
}