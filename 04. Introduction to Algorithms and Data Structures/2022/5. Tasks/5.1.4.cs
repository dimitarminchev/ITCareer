using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _514
{
    public class Search
    {
        public static int Linear<T>(T[] elements, T key) where T : IComparable
        {
            for (int index = 0; index < elements.Count(); index++)
            {
                if (elements[index].CompareTo(key) == 0)
                {
                    return index; // Found
                }
            }
            return -1; // Not Found
        }

        /// <summary>
        /// BinarySearch = Рекурсивно двоично търсене = O(log(n))
        /// </summary>
        public static int Binary<T>(T[] elements, T key) where T : IComparable
        {
            int start = 0, end = elements.Count() - 1;
            while (end >= start)
            {
                // middle
                int mid = (start + end) / 2;

                // compare
                if (elements[mid].CompareTo(key) > 0)
                {
                    // (mid > key) => key must be on left 
                    end = mid - 1;
                }
                else if (elements[mid].CompareTo(key) < 0)
                {
                    // (mid < key) => key must be on right 
                    start = mid + 1;
                }
                else
                {
                    // (mid == key) => found
                    return mid;
                }
            }
            // not found
            return -1;
        }

        /// <summary>
        /// Interpolation Search = Интерполационно търсене = O(log(log(N))
        /// </summary>
        public static int Interpolational(int[] sortedArray, int key)
        {
            // TODO: MUST BE FIXED ...
            int low = 0;
            int high = sortedArray.Length - 1;
            while (sortedArray[low] <= key && sortedArray[high] >= key)
            {
                int mid = (int)(low + ((double)(key - sortedArray[low]) * (high - low)) / (sortedArray[high] - sortedArray[low]));
                if (sortedArray[mid] < key) low = mid + 1;
                else if (sortedArray[mid] > key) high = mid - 1;
                else return mid;
            }
            if (sortedArray[low] == key) return low;
            else return -1;
        }
        
        // Fibonacci
        public static long Fibonacci(int[] arr, int x, int n)
        {
            long fibMMm2 = 0;
            long fibMMm1 = 1;
            long fibM = fibMMm2 + fibMMm1;
            while (fibM < n)
            {
                fibMMm2 = fibMMm1;
                fibMMm1 = fibM;
                fibM = fibMMm2 + fibMMm1;
            }
            long offset = -1;
            while (fibM > 1)
            {
                long i = offset + fibMMm2 > n-1 ? n-1 : offset + fibMMm2;
                if (arr[i] < x)
                {
                    fibM = fibMMm1;
                    fibMMm1 = fibMMm2;
                    fibMMm2 = fibM - fibMMm1;
                    offset = i;
                }
                else if (arr[i] > x)
                {
                    fibM = fibMMm2;
                    fibMMm1 = fibMMm1 - fibMMm2;
                    fibMMm2 = fibM - fibMMm1;
                }
                else return i;
            }
            if (fibMMm1 != 0 && arr[offset + 1] == x) return offset + 1;
            return -1;
        }
    }

    class Program
    {
        private static long MesureTime(Action metod)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            // Изпълнение на метода който желаем да тестваме
            metod();

            timer.Stop();
            Console.WriteLine("Time = {0} ticks", timer.ElapsedTicks);
            return timer.ElapsedTicks;
        }
        
        static void Main(string[] args)
        {
            // Входни данни
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("r=");
            int r = int.Parse(Console.ReadLine());

            // Приготвяне на тестери
            Random rnd = new Random();
            int[] test1 = new int[n];
            int[] test2 = new int[n];
            int[] test3 = new int[n];
            for (int i = 0; i < n; i++)
            {
                test1[i] = i + 1;
                test2[i] = n - i - 1;
                test3[i] = rnd.Next(1, n);
            }

            // Измерване време за сортиране
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int[] sortedTest2 = test2.OrderBy(x => x).ToArray();
            timer.Stop();
            long sortingTimeTest2=timer.ElapsedMilliseconds;
            timer.Restart();
            int[] sortedTest3 = test3.OrderBy(x => x).ToArray();
            timer.Stop();
            long sortingTimeTest3 = timer.ElapsedMilliseconds;

            long totalLinearTime = 0, totalBinaryTime = 0, totalFibonacciTime = 0, totalInterpolationTime = 0;
            
            // Тестер 1
            long linearTime = 0, binaryTime = 0, fibonacciTime = 0, interpolationTime=0;
            Console.WriteLine("\n\nSearch on Sorted Array:\n");
            for (int i = 0; i < r; i++)
            {
                int tester = rnd.Next(1, n);
                Console.Write($"{i+1}. Linear Search ");
                linearTime+= MesureTime(() => Search.Linear(test1, tester));
                Console.Write($"{i + 1}. Binary Search ");
                binaryTime+=MesureTime(() => Search.Binary(test1, tester));
                Console.Write($"{i + 1}. Fiboncci Search ");
                fibonacciTime+=MesureTime(() => Search.Fibonacci(test1, tester,test1.Length));
                Console.Write($"{i + 1}. Interpolation Search ");
                interpolationTime+=MesureTime(() => Search.Interpolational(test1, tester));
            }
            totalBinaryTime += binaryTime;totalFibonacciTime = fibonacciTime;totalInterpolationTime = interpolationTime;totalLinearTime = linearTime;
            Console.WriteLine("\nTotal Time: (Linear,Binary,Fibonacci,Interpolation)");
            Console.WriteLine($"{linearTime} {binaryTime} {fibonacciTime} {interpolationTime}\n\n");

            // Тестер 2
            linearTime = 0; binaryTime = fibonacciTime = interpolationTime = sortingTimeTest2;
            Console.WriteLine("Search on Reversed Sorted Array:\n");
            for (int i = 0; i < r; i++)
            {
                int tester = rnd.Next(1, n);
                Console.Write($"{i + 1}. Linear Search ");
                linearTime += MesureTime(() => Search.Linear(test2, tester));
                Console.Write($"{i + 1}. Binary Search ");
                binaryTime += MesureTime(() => Search.Binary(sortedTest2, tester));
                Console.Write($"{i + 1}. Fiboncci Search ");
                fibonacciTime += MesureTime(() => Search.Fibonacci(sortedTest2, tester, sortedTest2.Length));
                Console.Write($"{i + 1}. Interpolation Search ");
                interpolationTime += MesureTime(() => Search.Interpolational(sortedTest2, tester));
            }
            totalBinaryTime += binaryTime; totalFibonacciTime += fibonacciTime; totalInterpolationTime += interpolationTime; totalLinearTime += linearTime;
            Console.WriteLine("\nTotal Time: (Linear,Binary,Fibonacci,Interpolation)");
            Console.WriteLine($"{linearTime} {binaryTime} {fibonacciTime} {interpolationTime}\n\n");

            // Тестер 3
            linearTime = 0; binaryTime = fibonacciTime = interpolationTime = sortingTimeTest3;
            Console.WriteLine("Search on Random Array:\n");
            for (int i = 0; i < r; i++)
            {
                int tester = rnd.Next(1, n);
                Console.Write($"{i + 1}. Linear Search ");
                linearTime += MesureTime(() => Search.Linear(test3, tester));
                Console.Write($"{i + 1}. Binary Search ");
                binaryTime += MesureTime(() => Search.Binary(sortedTest3, tester));
                Console.Write($"{i + 1}. Fiboncci Search ");
                fibonacciTime += MesureTime(() => Search.Fibonacci(sortedTest3, tester,sortedTest3.Length));
                Console.Write($"{i + 1}. Interpolation Search ");
                interpolationTime += MesureTime(() => Search.Interpolational(sortedTest3, tester));
            }
            totalBinaryTime += binaryTime; totalFibonacciTime += fibonacciTime; totalInterpolationTime += interpolationTime; totalLinearTime += linearTime;
            Console.WriteLine("\nTotal Time: (Linear,Binary,Fibonacci,Interpolation)");
            Console.WriteLine($"{linearTime} {binaryTime} {fibonacciTime} {interpolationTime}");

            // Окончателни резултати
            Console.WriteLine("\n\n\nTotal results: (Linear,Binary,Fibonacci,Interpolation)");
            Console.WriteLine($"{totalLinearTime} {totalBinaryTime} {totalFibonacciTime} {totalInterpolationTime}\n");
        }
    }
}
