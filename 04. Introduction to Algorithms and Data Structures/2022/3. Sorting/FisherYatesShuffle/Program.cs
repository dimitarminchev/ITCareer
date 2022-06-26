using System;

namespace FisherYatesShuffle

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Колекция за сортиране
            int[] array = { -1, 9, 2, -8, 7, 6, -3, 5, 4, 1, 3 };

            // Отпечаваме на колекцията
            Console.WriteLine(String.Join(" ", array));

            // Разбъркване на колекцията
            Help.Shuffle(array);

            // Отпечаваме на колекцията
            Console.WriteLine(String.Join(" ", array));
        }
    }
}