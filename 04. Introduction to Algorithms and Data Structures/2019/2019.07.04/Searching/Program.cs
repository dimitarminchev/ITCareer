using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    class Program
    {
        // Измерване на време на работа на даден алгоритъм
        private static void MesureTime(Action metod)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            // Изпълнение на метода който желаем да тестваме
            metod();

            timer.Stop();
            Console.WriteLine("Time = {0} ms", timer.ElapsedMilliseconds);
        }

        static void Main(string[] args)
        {
            int index = 0;

            // Data Structure
            int key = 54321987;
            const int N = 100000000;
            int[] numbers = new int[N];
            for (int i = 0; i < N; i++) numbers[i] = i + 1;

            // 1. Linear Search 
            Console.WriteLine("1. Linear Search ... ");
            MesureTime(() => index = Search.Linear(numbers, key));            
            Console.WriteLine(index == -1 ? false : true);

            // 2. Recursive Binary Search 
            Console.WriteLine("2. Recursive Binary Search ... ");
            MesureTime(() => index = Search.RecursiveBinary(numbers, key, 0, numbers.Count() - 1));
            Console.WriteLine(index == -1 ? false : true);

            // 3. Binary Search 
            Console.WriteLine("3. Binary Search ... ");
            MesureTime(() => index = Search.Binary(numbers, key));
            Console.WriteLine(index == -1 ? false : true);

            // 4. Interpolational Search
            Console.WriteLine("4. Interpolational Search ... ");
            MesureTime(() => index = Search.Interpolational(numbers, key));
            Console.WriteLine(index == -1 ? false : true);

            // 5. Easy Search
            Console.WriteLine("5. Easy Search ... ");
            MesureTime(() => index = Search.Easy(numbers, key));
            Console.WriteLine(index == -1 ? false : true);
        }
    }
}
