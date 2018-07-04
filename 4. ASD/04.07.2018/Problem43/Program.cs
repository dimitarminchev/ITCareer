using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem43
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 3. Визуализация на сортирането
            int[] elements = new int[] { 1, 7, 4, 10, 5, 45, 12, 18, 3, 8, 1 };
            Console.WriteLine("Start array: " + String.Join(" ", elements));
            Console.WriteLine();
            Sorter.BubbleSort(elements);
            Sorter.InsertionSort(elements);

            // Problem 4. Брой на инверсиите

            // Problem 5. Най-често срещано число

            // Problem 6. Най-бърз подреждач

            // Problem 7. Топове плат
        }
    }
}
