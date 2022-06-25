using System.Collections;

namespace LinkedQueue
{
    /// <summary>
    /// Двойно свързана опашка
    /// </summary>
    public class LinkedQueue<T> : IEnumerable<T>
    {
        public int Count { get; private set; }
        private QueueNode<T> head;
        private QueueNode<T> tail;

        /// <summary>
        /// Конструктор
        /// </summary>
        public LinkedQueue()
        {
            this.head = null;
            this.tail = null;
            this.Count = 0;
        }

        /// <summary>
        /// Добавяне
        /// </summary>
        public void Enqueue(T item)
        {
            if (this.Count == 0)
            {
                this.head = new QueueNode<T>(item);
                this.tail = new QueueNode<T>(item);
            }
            else
            {
                QueueNode<T> newTail = new QueueNode<T>(item);
                newTail.Prev = this.tail;
                this.tail.Next = newTail;
                this.tail = newTail;
                if (this.Count == 1) this.head.Next = newTail;
            }
            this.Count++;
        }

        /// <summary>
        /// Премахване
        /// </summary>
        public T Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Empty!");
            }

            QueueNode<T> firstElement = this.head;
            this.head = this.head.Next;
            if (this.head != null)
            {
                this.head.Prev = null;
            }
            else
            {
                this.tail = null;
            }
            this.Count--;
            return firstElement.Value;
        }

        // Нумератор за обхождане 
        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = this.head;
            while (currentNode != null)
            {
                T val = currentNode.Value;
                currentNode = currentNode.Next;
                yield return val;

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
