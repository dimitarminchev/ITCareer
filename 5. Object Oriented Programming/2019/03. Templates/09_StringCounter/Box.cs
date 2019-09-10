using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StringCounter
{
    public class Box<T> where T : IComparable
    {
        private List<T> items;

        public Box()
        {
            items = new List<T>();
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
            items.Add(element);
        }

        public T Remove()
        {
            T remove = items.Last();
            items.Remove(items.Last());
            return remove;
        }

        public void Print()
        {
            foreach (var item in items)
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
