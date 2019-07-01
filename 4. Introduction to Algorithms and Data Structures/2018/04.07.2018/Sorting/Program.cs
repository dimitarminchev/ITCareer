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
        // Измерване на време на работа на алгоритъма
        private static Stopwatch timer;

        static void Main(string[] args)
        {
            // 0. Data Structure
            const int SIZE = 1000;
            int[] numbers = new int[SIZE];
            for (int i = 0; i < SIZE; i++) numbers[i] = i;

            // 1. Shifting = O(N)
            timer = new Stopwatch();
            timer.Start();
            Sorting.Shifting(numbers);
            timer.Stop();
            Console.WriteLine("Shifting ... ");
            // Console.WriteLine(string.Join(",", numbers));
            Console.WriteLine("Time = {0} ms\n", timer.Elapsed.TotalMilliseconds);

            // 2. SelectionSort = O(N^2)
            timer = new Stopwatch();
            timer.Start();
            Sorting.SelectionSort(numbers);
            timer.Stop();
            Console.WriteLine("SelectionSort ... ");
            // Console.WriteLine(string.Join(",", numbers));
            Console.WriteLine("Time = {0} ms\n", timer.Elapsed.TotalMilliseconds);

            // 3. BubbleSort = O(N^2)
            timer = new Stopwatch();
            timer.Start();
            Sorting.BubbleSort(numbers);
            timer.Stop();
            Console.WriteLine("BubbleSort ... ");
            // Console.WriteLine(string.Join(",", numbers));
            Console.WriteLine("Time = {0} ms\n", timer.Elapsed.TotalMilliseconds);

            // 4. InsertionSort = O(N^2)
            timer = new Stopwatch();
            timer.Start();
            Sorting.InsertionSort(numbers);
            timer.Stop();
            Console.WriteLine("InsertionSort ... ");
            // Console.WriteLine(string.Join(",", numbers));
            Console.WriteLine("Time = {0} ms\n", timer.Elapsed.TotalMilliseconds);

            // 5. MergeSort = O(N * log(N))
            timer = new Stopwatch();
            timer.Start();
            Sorting.MergeSort(numbers);
            timer.Stop();
            Console.WriteLine("MergeSort ... ");
            // Console.WriteLine(string.Join(",", numbers));
            Console.WriteLine("Time = {0} ms\n", timer.Elapsed.TotalMilliseconds);

            // 6. QuickSort = O(N * log(N))
            timer = new Stopwatch();
            timer.Start();
            Sorting.QuickSort(numbers);
            timer.Stop();
            Console.WriteLine("QuickSort ... ");
            // Console.WriteLine(string.Join(",", numbers));
            Console.WriteLine("Time = {0} ms\n", timer.Elapsed.TotalMilliseconds);

        }
    }
}
