using System;

namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SelectionSort:");

            // Колекция за сортиране
            int[] array = { -1, 9, 2, -8, 7, 6, -3, 5, 4, 1, 3 };

            // Отпечаваме на колекцията
            Console.WriteLine(String.Join(" ", array));

            // Сортиране на колекцията
            SelectionSort.Sort(array);

            // Отпечаваме на колекцията
            Console.WriteLine(String.Join(" ", array));
        }
    }
}