using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _413
{
    public static class Help
    {
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

        /// <summary>
        /// Сортиране по метода на пряката селекция = O(N^2)
        /// </summary>
        public static void Selection<T>(T[] elements) where T : IComparable
        {
            for (int i = 0; i < elements.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < elements.Length; j++)
                {
                    if (Help.IsLess(elements[min], elements[j]))
                    {
                        min = j;
                    }
                }
                Help.Swap(elements, min, i);
            }
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 95, 98, 103, 109, 48, 92, 25, 106, 160 };

            Console.WriteLine(string.Join(" ", arr));

            Sort.Selection<int>(arr);

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
