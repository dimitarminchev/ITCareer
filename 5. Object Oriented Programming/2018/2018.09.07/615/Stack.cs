using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _615
{
    public class Stack<T> : IEnumerable<T>
    {
        private int top = 0;
        private List<T> stack;

        public Stack()
        {
            this.stack = new List<T>();
        }

        public void Push(params T[] items)
        {
            foreach (var item in items)
            {
                this.stack.Add(item);
                this.top++;
            }
        }
        public T Pop()
        {
            var item = this.stack[top-1];
            this.stack.RemoveAt(this.top-1);
            this.top--;
            return item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.stack.Count; i++)
            yield return this.stack[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
