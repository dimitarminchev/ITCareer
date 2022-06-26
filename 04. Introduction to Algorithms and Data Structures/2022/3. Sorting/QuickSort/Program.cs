using System;

namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QuickSort:");

            // Колекция за сортиране, Разбъркване и Отпечатване
            int[] array = { -1, 9, 2, -8, 7, 6, -3, 5, 4, 1, 3 };
            Help.Shuffle(array);
            Console.WriteLine(String.Join(" ", array));

            // Сортиране на колекцията
            QuickSort.Sort(array);

            // Отпечаваме на колекцията
            Console.WriteLine(String.Join(" ", array));
        }
    }
}