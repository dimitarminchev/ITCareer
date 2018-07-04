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
        private static Stopwatch timer = new Stopwatch();

        static void Main(string[] args)
        {
            // 0. Data Structure
            const int SIZE = 100;
            int[] numbers = new int[SIZE];
            for (int i = 0; i < SIZE; i++) numbers[i] = i;

            // 1. Shifting = O(N)
            timer.Reset();
            timer.Start();
            Sorting.Shifting(numbers);
            timer.Stop();
            Console.WriteLine("Shifting...\n{0}",string.Join(",", numbers));          
            Console.WriteLine("Time = {0} ms\n", timer.Elapsed.TotalMilliseconds);

            // 2. SelectionSort = O(N^2)
            timer.Reset();
            timer.Start();
            Sorting.SelectionSort(numbers);
            timer.Stop();
            Console.WriteLine("SelectionSort...\n{0}", string.Join(",", numbers));
            Console.WriteLine("Time = {0} ms\n", timer.Elapsed.TotalMilliseconds);

            // 3. Shifting = O(N)
            timer.Reset();
            timer.Start();
            Sorting.Shifting(numbers);
            timer.Stop();
            Console.WriteLine("Shifting...\n{0}", string.Join(",", numbers));
            Console.WriteLine("Time = {0} ms\n", timer.Elapsed.TotalMilliseconds);

            // 4. BubbleSort = O(N^2)
            timer.Reset();
            timer.Start();
            Sorting.BubbleSort(numbers);
            timer.Stop();
            Console.WriteLine("BubbleSort...\n{0}", string.Join(",", numbers));
            Console.WriteLine("Time = {0} ms\n", timer.Elapsed.TotalMilliseconds);

            // 5. Shifting = O(N)
            timer.Reset();
            timer.Start();
            Sorting.Shifting(numbers);
            timer.Stop();
            Console.WriteLine("Shifting...\n{0}", string.Join(",", numbers));
            Console.WriteLine("Time = {0} ms\n", timer.Elapsed.TotalMilliseconds);

            // 6. InsertionSort = O(N^2)
            timer.Reset();
            timer.Start();
            Sorting.InsertionSort(numbers);
            timer.Stop();
            Console.WriteLine("InsertionSort...\n{0}", string.Join(",", numbers));
            Console.WriteLine("Time = {0} ms\n", timer.Elapsed.TotalMilliseconds);

            // 7. Shifting = O(N)
            timer.Reset();
            timer.Start();
            Sorting.Shifting(numbers);
            timer.Stop();
            Console.WriteLine("Shifting...\n{0}", string.Join(",", numbers));
            Console.WriteLine("Time = {0} ms\n", timer.Elapsed.TotalMilliseconds);

            // 8. MergeSort = O(N * log(N))
            timer.Reset();
            timer.Start();
            Sorting.MergeSort(numbers);
            timer.Stop();
            Console.WriteLine("MergeSort...\n{0}", string.Join(",", numbers));
            Console.WriteLine("Time = {0} ms\n", timer.Elapsed.TotalMilliseconds);
        }
    }
}
