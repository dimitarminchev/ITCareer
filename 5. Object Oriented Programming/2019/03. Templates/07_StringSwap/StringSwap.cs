using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StringSwap
{
    public class StringSwap<T>
    {
        private T[] array;
        private int index; 

        public StringSwap(int capacity)
        {
            this.array = new T[capacity];
            this.index = 0;
        }

        public void Add(T item)
        {
            this.array[index] = item;
            this.index++;
        }

        public void Swap(int first, int second)
        {
            T temp = this.array[first];
            this.array[first] = this.array[second];
            this.array[second] = temp;
        }

        public void Print()
        {
            foreach (var item in array)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }
    }
}
