
using System.Collections;

namespace LinkedStack
{
    /// <summary>
    /// Свързан стек
    /// </summary>
    public class LinkedStack<T> : IEnumerable<T>
    {
        // Първи елемент
        private Node<T> first;

        // Брой елементи
        public int Count { get; private set; }

        /// <summary>
        /// Добавяне
        /// </summary>
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

        /// <summary>
        /// Изтриване
        /// </summary>
        public T Pop()
        {
            Node<T> node = this.first;
            this.first = first.Next;
            this.Count--;
            return first.Value;
        }

        /// <summary>
        /// Масив
        /// </summary>
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

        // Нумемратор
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
