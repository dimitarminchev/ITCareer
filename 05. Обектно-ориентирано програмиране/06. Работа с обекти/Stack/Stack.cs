using System.Collections;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        public T[] array;
        public int count;

        public Stack()
        {
            array = new T[5];
            count = -1;
        }

        public void Push(T item)
        {
            count++;
            if (count > array.Length)
            {
                Array.Resize<T>(ref array, count + 1);
            }

            array[count] = item;
        }

        public T Pop()
        {
            if (count > 0)
            {
                count--;
                return array[count + 1];
            }
            else
            {
                return array[count];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MyEnumerator<T>(this);
        }
    }
}