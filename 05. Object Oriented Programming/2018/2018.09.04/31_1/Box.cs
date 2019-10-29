using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_1
{
    // Problem 1. Кутия с T 
    public class Box<T>
    {
        private int count;
        private List<T> list;
        public Box()
        {
            list = new List<T>();
            this.count = 0;
        }
        public int Count
        {
            get { return count; }
        }
        public void Add(T element)
        {
            list.Add(element);
            count++;
        }
        public T Remove()
        {
            var remove = list.Last();
            list.Remove(list.Last());
            count--;
            return remove;
        }
        public void Print()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
