using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _615
{
    class MyEnumerator<T> : IEnumerator<T>
    {
        private int position;
        private Stack<T> stack;

        public MyEnumerator(Stack<T> stack)
        {
            this.stack = stack;
            position = -1;
        }
        public void Dispose()
        {

        }
        public void Reset()
        {
            position = -1;
        }

        public bool MoveNext()
        {
            position++;
            return position <= stack.count;
        }

        Object IEnumerator.Current
        {
            get
            {
                return stack.array[position];
            }
        }
        public T Current
        {
            get
            {
                return stack.array[position];
            }
        }
    }
}
