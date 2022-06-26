using System;

namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Колекция за сортиране
            int[] array = { -1, 9, 2, -8, 7, 6, -3, 5, 4, 1, 3 };

            // Отпечаваме на колекцията
            Console.WriteLine(String.Join(" ", array));

            // Сортиране на колекцията
            InsertionSort.Sort(array);

            // Отпечаваме на колекцията
            Console.WriteLine(String.Join(" ", array));
        }
    }
}