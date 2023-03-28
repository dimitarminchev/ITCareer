using System.Collections;

namespace LinkedQueue
{
    public class LinkedQueue<T> : IEnumerable<T>
    {
        public int Count { get; private set; }
        private QueueNode<T> head;
        private QueueNode<T> tail;

        public LinkedQueue()
        {
            this.head = null;
            this.tail = null;
            this.Count = 0;
        }

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