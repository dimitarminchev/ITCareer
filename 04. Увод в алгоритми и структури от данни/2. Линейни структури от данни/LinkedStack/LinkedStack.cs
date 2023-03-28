using System.Collections;

namespace LinkedStack
{
    public class LinkedStack<T> : IEnumerable<T>
    {
        private Node<T> first;

        public int Count { get; private set; }

        public void Push(T element)
        {
            if (Count == 0)
            {
                this.first = new Node<T>(element);
            }
            else
            {
                Node<T> next = this.first;
                this.first = new Node<T>(element, next);
            }
            Count++;
        }

        public T Pop()
        {
            Node<T> node = this.first;
            this.first = first.Next;
            this.Count--;
            return first.Value;
        }

        public T[] ToArray()
        {
            T[] result = new T[Count];
            Node<T> current = this.first;
            int ind = 0;
            while (current != null)
            {
                result[ind] = current.Value;
                current = current.Next;
                ind++;
            }
            return result.ToArray();
        }

        public IEnumerator<T> GetEnumerator()
        {
            var items = this.ToArray();
            for (int i = 0; i < items.Length; i++)
            {
                yield return items[i];
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}