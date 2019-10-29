using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DoubleCounter
{
    public class Box<T> where T : IComparable
    {
        private List<T> items;

        public int Count { get; private set; }

        public Box()
        {
            this.items = new List<T>();
            this.Count = 0;
        }

        public int BiggerThan(T element)
        {
            int count = 0;
            foreach (var item in this.items)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }

        public void Add(T element)
        {
            this.items.Add(element);
            this.Count++;
        }

        public T Remove()
        {
            T remove = this.items.Last();
            this.items.Remove(items.Last());
            this.Count--;
            return remove;
        }

        public void Print()
        {
            foreach (var item in this.items)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }

        public override string ToString()
        {
            string temp = null, type = null;
            foreach (var item in items)
            {
                type = item.GetType().ToString();
                temp += item.ToString();
            };
            return $"{type}: {temp}";
        }
    }
}
