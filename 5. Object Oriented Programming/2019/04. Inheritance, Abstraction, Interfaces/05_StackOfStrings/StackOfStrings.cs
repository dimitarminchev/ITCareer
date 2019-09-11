using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_StackOfStrings
{
    public class StackOfStrings<T> : List<T>, IEnumerable<T>
    {
        private List<T> data = new List<T>();

        public void Push(T element)
        {
            this.data.Add(element);
        }

        public T Pop()
        {
            var element = this.data.Last();
            this.data.Remove(element);
            return element;
        }

        public T Peek()
        {
            return this.data.Last();
        }

        public bool IsEmpty()
        {
            return this.data.Count == 0 ? true : false; 
        }


        // Нумератор
        public new IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.data.Count(); i++)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
