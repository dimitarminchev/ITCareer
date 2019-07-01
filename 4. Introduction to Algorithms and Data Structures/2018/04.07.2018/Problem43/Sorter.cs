using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem43
{
    public static class Sorter
    {


        public static void BubbleSort<T>(T[] elements)
            where T : IComparable<T>
        {
            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = 0; j < elements.Length - 1 - i; j++)
                {
                    if (IsLess(elements[j + 1], elements[j]))
                        Swap(elements, j + 1, j);
                }
            }
        }
        public static void InsertionSort<T>(T[] elements)
            where T : IComparable<T>
        {
            for (int i = 1; i < elements.Length; i++)
            {
                int indexToInsert = i;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (IsLess(elements[i], elements[j]))
                        indexToInsert = j;
                }
                if (indexToInsert != i) Insert(elements, indexToInsert, i);
            }
        }

        private static bool IsLess<T>(T t1, T t2)
            where T : IComparable<T>
        {
            return t1.CompareTo(t2) == -1;
        }



        private static void Insert<T>(T[] elements, int indexToInsert, int oldElementIndex)
            where T : IComparable<T>
        {
            T[] newElements = elements;

            T elementToInsert = elements[oldElementIndex];
            Console.WriteLine($"Inserting {elementToInsert} at index {indexToInsert}");
            for (int i = oldElementIndex; i < elements.Length - 1; i++)
            {
                newElements[i] = newElements[i + 1];
            }

            for (int i = elements.Length - 1; i > indexToInsert; i--)
            {
                newElements[i] = newElements[i - 1];
            }
            newElements[indexToInsert] = elementToInsert;

            for (int i = 0; i < newElements.Length - 1; i++)
            {
                elements[i] = newElements[i];
            }

            Console.WriteLine(String.Join(" ", elements));
            Console.WriteLine();
        }

        private static void Swap<T>(T[] elements, int firstElementIndex, int secondElementIndex)
            where T : IComparable<T>
        {
            Console.WriteLine($"Swapping {elements[firstElementIndex]} and {elements[secondElementIndex]}");
            Console.WriteLine(String.Join(" ", elements));
            Console.WriteLine();
            T temp = elements[firstElementIndex];
            elements[firstElementIndex] = elements[secondElementIndex];
            elements[secondElementIndex] = temp;
        }
    }
}
