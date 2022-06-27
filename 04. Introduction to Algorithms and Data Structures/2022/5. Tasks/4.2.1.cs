using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421
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
        /// <summary>
        /// Сортиране по метода на пряката селекция = O(N^2)
        /// </summary>
        public static void Bubble<T>(T[] elements) where T : IComparable
        {
            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = 0; j < elements.Length; j++)
                {
                    if(Help.IsLess(elements[i],elements[j]))
                    {
                        Help.Swap(elements, i, j);
                    }
                }
            }
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Sort.Bubble(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
