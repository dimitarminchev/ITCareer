using System;

namespace FisherYatesShuffle

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 x Fisher-Yates Shuffle:");

            // Колекция за сортиране
            int[] array = { -1, 9, 2, -8, 7, 6, -3, 5, 4, 1, 3 };

            // Разбъркване и отпечатване на колекцията
            Help.Shuffle(array);
            Console.WriteLine(String.Join(" ", array));

            // Разбъркване и отпечатване на колекцията
            Help.Shuffle(array);
            Console.WriteLine(String.Join(" ", array));

            // Разбъркване и отпечатване на колекцията
            Help.Shuffle(array);
            Console.WriteLine(String.Join(" ", array));

        }
    }
}