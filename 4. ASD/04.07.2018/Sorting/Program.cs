using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {

        static void Main(string[] args)
        {
            // 0. Data Structure
            const int SIZE = 100;
            int[] numbers = new int[SIZE];
            for (int i = 0; i < SIZE; i++) numbers[i] = i;

            // 1. Shifting = O(N)
            Sorting.Shifting(numbers);
            Console.WriteLine("Shifting...\n{0}",string.Join(",", numbers));          

            // 2. SelectionSort = O(N^2)
            Sorting.SelectionSort(numbers);
            Console.WriteLine("SelectionSort...\n{0}", string.Join(",", numbers));

            // 3. BubbleSort = O(N^2)
            Sorting.BubbleSort(numbers);
            Console.WriteLine("BubbleSort...\n{0}", string.Join(",", numbers));

            // 4. InsertionSort = O(N^2)
            Sorting.InsertionSort(numbers);
            Console.WriteLine("InsertionSort...\n{0}", string.Join(",", numbers));

            // 5. MergeSort = O(N * log(N))
            Sorting.MergeSort(numbers);
            Console.WriteLine("MergeSort...\n{0}", string.Join(",", numbers));

            // 6. QuickSort = O(N * log(N))
            Sorting.QuickSort(numbers);
            Console.WriteLine("QuickSort...\n{0}", string.Join(",", numbers));
        }
    }
}
