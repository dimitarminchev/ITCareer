using System;

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Колекция за сортиране
            int[] array = { -1, 9, 2, -8, 7, 6, -3, 5, 4, 1, 3 };

            // 1, Сортиране чрез селекция
            Console.WriteLine("SelectionSort:");
            Sort.Selection(array);
            Console.WriteLine(String.Join(" ", array));
            Help.Shuffle(array);

            // 2. Сортиране чрез метода мехурчето
            Console.WriteLine("BubbleSort:");
            Sort.Bubble(array);
            Console.WriteLine(String.Join(" ", array));
            Help.Shuffle(array);

            // 3. Сортиране чрез вмъкване
            Console.WriteLine("InsertionSort:");
            Sort.Insertion(array);
            Console.WriteLine(String.Join(" ", array));
            Help.Shuffle(array);

            // 4. Сортиране чрез сливане
            Console.WriteLine("MergeSort:");
            Sort.Merge(array);
            Console.WriteLine(String.Join(" ", array));
            Help.Shuffle(array);

            // 5. Бързо сортиране
            Console.WriteLine("QuickSort:");
            Sort.Quick(array);
            Console.WriteLine(String.Join(" ", array));
            Help.Shuffle(array);

        }
    }
}