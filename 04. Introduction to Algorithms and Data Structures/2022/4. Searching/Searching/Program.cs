using System.Diagnostics;

namespace Searching
{
    class Program
    {
        // Измерване на времето на работа на даден алгоритъм
        private static void MesureTime(Action method)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            // Изпълнение на метода който ще тестваме
            method();

            timer.Stop();
            Console.WriteLine("Time = {0} ms", timer.ElapsedMilliseconds);
        }

        static void Main(string[] args)
        {
            // Резултат от тъсенето
            int index = 0; 

            // Структурата от данни
            const int N = 100000000;
            int[] numbers = new int[N];
            for (int i = 0; i < N; i++) numbers[i] = i + 1;

            // Тъсен елемент
            int key = 54321987;

            // 1. Linear Search
            Console.WriteLine("1. Linar Search ... ");
            MesureTime(() => Search.Linear(numbers, key));
            Console.WriteLine(index == -1 ? false : true);

            // 2. Recursive Binary Search
            Console.WriteLine("2.Recursive Binary Search ... ");
            MesureTime(() => Search.RecursiveBinary(numbers, key, 0, numbers.Count()-1));
            Console.WriteLine(index == -1 ? false : true);

            // 3. Binary Search
            Console.WriteLine("3. Binary Search ... ");
            MesureTime(() => Search.Binary(numbers, key, 0, numbers.Count() - 1));
            Console.WriteLine(index == -1 ? false : true);

            // 4. Interpolation Search ...
            Console.WriteLine("4. Interpolation Search ... ");
            MesureTime(() => Search.Interpolation(numbers, key));
            Console.WriteLine(index == -1 ? false : true);

            // 5. Easy Search ...
            Console.WriteLine("5. Easy Search ... ");
            MesureTime(() => Search.Easy(numbers, key));
            Console.WriteLine(index == -1 ? false : true);
        }
    }
}