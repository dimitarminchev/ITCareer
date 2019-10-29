using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedQueue
{
    public class QueueNode<T>
    {
        // Стойност на елемент
        public T Value { get; private set; }

        // Следващ елемент
        public QueueNode<T> NextNode { get; set; }

        // Предишен елемент
        public QueueNode<T> PrevNode { get; set; }

        // Конструктор
        public QueueNode(T value)
        {
            this.Value = value;
        }
    }

    public class LinkedQueue<T> : IEnumerable<T>
    {
        public int Count { get; private set; }
        private QueueNode<T> head;
        private QueueNode<T> tail;

        // Конструктор
        public LinkedQueue()
        {
            this.head = null;
            this.tail = null;
            this.Count = 0;
        }

        // Добавяне
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
                newTail.PrevNode = this.tail;
                this.tail.NextNode = newTail;
                this.tail = newTail;
                if (this.Count == 1) this.head.NextNode = newTail;
            }
            this.Count++;
        }

        // Премахване
        public T Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Empty!");
            }

            QueueNode<T> firstElement = this.head;
            this.head = this.head.NextNode;
            if (this.head != null)
            {
                this.head.PrevNode = null;
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
                currentNode = currentNode.NextNode;
                yield return val;

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
