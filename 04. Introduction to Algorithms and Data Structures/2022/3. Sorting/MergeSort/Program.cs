using System;

namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MergeSort:");

            // Колекция за сортиране, Разбъркване и Отпечатване
            int[] array = { -1, 9, 2, -8, 7, 6, -3, 5, 4, 1, 3 };
            Help.Shuffle(array);
            Console.WriteLine(String.Join(" ", array));

            // Сортиране на колекцията
            MergeSort.Sort(array);

            // Отпечаваме на колекцията
            Console.WriteLine(String.Join(" ", array));
        }
    }
}