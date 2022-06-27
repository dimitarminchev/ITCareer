using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _436
{
    public static class Help
    {
        // Случайно число
        public static Random random = new Random();

        /// <summary>
        /// Разбъркване = O(N)
        /// </summary>
        public static void Shuffle<T>(T[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                int r = i + random.Next(0, elements.Length - i);
                Help.Swap(elements, i, r);
            }
        }

        // Размяна на два елемента = O(1)
        public static void Swap<T>(T[] elements, int first, int second)
        {
            T temp = elements[first];
            elements[first] = elements[second];
            elements[second] = temp;
        }

        // Дали даден елемент е по малък от друг = O(1)
        public static bool IsLess(IComparable first, IComparable second)
        {
            return first.CompareTo(second) < 0;
        }

        // Проверка дали структурата е сортирана = O(N)
        public static bool IsSorted<T>(T[] elements) where T : IComparable
        {
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i - 1].CompareTo(elements[i]) > 0)
                {
                    return false;
                }
            }
            return true;
        }
    }

    public static class Sort
    {
        /// <summary>
        /// Сортиране по метода на пряката селекция = O(N^2)
        /// </summary>
        public static void Bubble<T>(T[] elements) where T : IComparable
        {
            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = 0; j < elements.Length; j++)
                {
                    if (Help.IsLess(elements[i], elements[j]))
                    {
                        Help.Swap(elements, i, j);
                    }
                }
            }
        }

        /// <summary>
        /// Сортиране по метода на пряката селекция = O(N^2)
        /// </summary>
        public static void Insertion<T>(T[] elements) where T : IComparable
        {
            for (int i = 0; i < elements.Length; i++)
            {
                int prev = i - 1;
                int curr = i;
                while (true)
                {
                    if (prev < 0 || Help.IsLess(elements[prev], elements[curr]))
                    {
                        break;
                    }
                    Help.Swap(elements, curr, prev);
                    curr--;
                    prev--;
                }
            }
        }

        // TODO: Add more sorting algorithms ....
    }

    public class Program
    {
        // Случайно число
        public static Random random = new Random();

        // Измерване на времето на работа на даден алгоритъм
        public static void MesureTime(Action method)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            // Изпълнение на метода който ще тестваме
            method();

            timer.Stop();
            Console.WriteLine("Time = {0} ms", timer.ElapsedMilliseconds);
        }

        public static void Main(string[] args)
        {
            // Generate Array
            const int N = 10000;
            int[] numbers = new int[N];
            for (int i = 0; i < N; i++) numbers[i] = random.Next(0, N);

            // Mesure Execution time 
            Console.Write("Bubble Sort ... ");
            MesureTime(() => Sort.Bubble(numbers));

            Console.Write("Shuffle ... ");
            MesureTime(() => Help.Shuffle(numbers));

            Console.Write("Insertion Sort ... ");
            MesureTime(() => Sort.Insertion(numbers));

        }
    }
}
