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
        public static Stopwatch sw = new Stopwatch();

        static void Main(string[] args)
        {
            // Масив
            const int N = 20000;
            var numbers = new int[N];
            for (int i = 0; i < N; i++) numbers[i] = i+1;

            // Shuffle
            Sort.Shuffle(numbers);

            // 1. Selection Sort = O(N^2)
            sw.Restart();
            Sort.Selection(numbers);
            sw.Stop();
            Console.WriteLine("Selection Sort Time: {0} ms", sw.ElapsedMilliseconds);

            // Shuffle
            Sort.Shuffle(numbers);

            // 2. Bubble Sort = O(N^2)
            sw.Restart();
            Sort.Bubble(numbers);
            sw.Stop();
            Console.WriteLine("Bubble Sort Time: {0} ms", sw.ElapsedMilliseconds);

            // Shuffle
            Sort.Shuffle(numbers);

            // 3. Insertion Sort = O(N^2)
            sw.Restart();
            Sort.Insertion(numbers);
            sw.Stop();
            Console.WriteLine("Insertion Sort Time: {0} ms", sw.ElapsedMilliseconds);

            // Shuffle
            Sort.Shuffle(numbers);

            // 4. Merge Sort =  O(N*log(N))
            sw.Restart();
            Sort.Merge(numbers);
            sw.Stop();
            Console.WriteLine("Merge Sort Time: {0} ms", sw.ElapsedMilliseconds);

            // Shuffle
            Sort.Shuffle(numbers);

            // 5. Quick Sort = O(N*log(N))
            sw.Restart();
            Sort.Quick(numbers);
            sw.Stop();
            Console.WriteLine("Quick Sort Time: {0} ms", sw.ElapsedMilliseconds);

        }
    }
}
