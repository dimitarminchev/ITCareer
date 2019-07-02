using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    public class LinkedStack<T> : IEnumerable<T>
    {
        // Първи елемент
        private Node<T> firstNode;

        // Брой елементи
        public int Count { get; private set; }

        // Добавяне
        public void Push(T element)
        {
            if (Count == 0)
            {
                this.firstNode = new Node<T>(element);
            }
            else
            {
                Node<T> nextNode = this.firstNode;
                this.firstNode = new Node<T>(element, nextNode);
            }
            Count++;
        }

        // Изтриване
        public T Pop()
        {
            Node<T> fNode = this.firstNode;
            this.firstNode = firstNode.NextNode;
            return fNode.Value;
        }

        // Масив
        public T[] ToArray()
        {
            T[] result = new T[Count];
            Node<T> current = this.firstNode;
            int ind = 0;
            while (current != null)
            {
                result[ind] = current.Value;
                current = current.NextNode;
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
