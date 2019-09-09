using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_2
{
   public class CustomList<T> where T : IComparable
    {
        private List<T> lis;
        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public CustomList()
        {
            lis = new List<T>();
            this.count = 0;
        }
        public void Add(T element)
        {
            lis.Add(element);
            this.count++;
        }
        public T Remove(int index)
        {
            var re = lis[index];
            lis.Remove(lis[index]);
            this.count--;
            return re;

        }
        public bool Contains(T element)
        {
            bool re = false;
            foreach (var it in lis)
            {
                if (it.Equals(element)) re = true;
            }
            return re;
        }
        public void Swap(int index1, int index2)
        {
            var pazq = lis[index1];
            lis[index1] = lis[index2];
            lis[index2] = pazq;
        }
        public int CountGreaterThan(T element)
        {
            var counter = 0;
            foreach (var item in lis)
            {
                var e = element.CompareTo(item);
                if (e == -1) counter++;
            }
            return counter;
        }
        public T Max()
        {
            return lis.Max();
        }
        public T Min()
        {
            return lis.Min();
        }
        public override string ToString()
        {
            string temp = null;
            foreach (var it in lis)
            {
                temp += $"{it} ";
            }
            return temp;
        }
    }
}
