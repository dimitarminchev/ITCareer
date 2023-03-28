using System.Diagnostics;

namespace SearchContest
{
    class Program
    {
        private static long MesureTime(Action metod)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            metod();

            timer.Stop();
            Console.WriteLine("Time = {0} ticks", timer.ElapsedTicks);
            return timer.ElapsedTicks;
        }

        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("r=");
            int r = int.Parse(Console.ReadLine());

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

            Stopwatch timer = new Stopwatch();
            timer.Start();
            int[] sortedTest2 = test2.OrderBy(x => x).ToArray();
            timer.Stop();
            long sortingTimeTest2 = timer.ElapsedMilliseconds;
            timer.Restart();
            int[] sortedTest3 = test3.OrderBy(x => x).ToArray();
            timer.Stop();
            long sortingTimeTest3 = timer.ElapsedMilliseconds;

            long totalLinearTime = 0, totalBinaryTime = 0, totalFibonacciTime = 0, totalInterpolationTime = 0;


            long linearTime = 0, binaryTime = 0, fibonacciTime = 0, interpolationTime = 0;
            Console.WriteLine("\n\nSearch on Sorted Array:\n");
            for (int i = 0; i < r; i++)
            {
                int tester = rnd.Next(1, n);
                Console.Write($"{i + 1}. Linear Search ");
                linearTime += MesureTime(() => Search.Linear(test1, tester));
                Console.Write($"{i + 1}. Binary Search ");
                binaryTime += MesureTime(() => Search.Binary(test1, tester));
                Console.Write($"{i + 1}. Fiboncci Search ");
                fibonacciTime += MesureTime(() => Search.Fibonacci(test1, tester, test1.Length));
                Console.Write($"{i + 1}. Interpolation Search ");
                interpolationTime += MesureTime(() => Search.Interpolational(test1, tester));
            }
            totalBinaryTime += binaryTime; totalFibonacciTime = fibonacciTime; totalInterpolationTime = interpolationTime; totalLinearTime = linearTime;
            Console.WriteLine("\nTotal Time: (Linear,Binary,Fibonacci,Interpolation)");
            Console.WriteLine($"{linearTime} {binaryTime} {fibonacciTime} {interpolationTime}\n\n");

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
                fibonacciTime += MesureTime(() => Search.Fibonacci(sortedTest3, tester, sortedTest3.Length));
                Console.Write($"{i + 1}. Interpolation Search ");
                interpolationTime += MesureTime(() => Search.Interpolational(sortedTest3, tester));
            }
            totalBinaryTime += binaryTime; totalFibonacciTime += fibonacciTime; totalInterpolationTime += interpolationTime; totalLinearTime += linearTime;
            Console.WriteLine("\nTotal Time: (Linear,Binary,Fibonacci,Interpolation)");
            Console.WriteLine($"{linearTime} {binaryTime} {fibonacciTime} {interpolationTime}");

            Console.WriteLine("\n\n\nTotal results: (Linear,Binary,Fibonacci,Interpolation)");
            Console.WriteLine($"{totalLinearTime} {totalBinaryTime} {totalFibonacciTime} {totalInterpolationTime}\n");
        }
    }

}