using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        // Глава
        private ListNode<T> Head { get; set; }

        // Опашка
        private ListNode<T> Tail { get; set; }

        // Брой елементи
        public int Count { get; private set; }


        // Добавяне на първи елемент
        public void AddFirst(T element)
        {
            if (Count == 0)
            {
                this.Head = this.Tail = new ListNode<T>(element);
            }
            else
            {
                var newone = new ListNode<T>(element);
                newone.Next = this.Head;
                this.Head.Prev = newone;
                this.Head = newone;
            }
            this.Count++;
        }

        // Добавяне на последен елемент
        public void AddLast(T element)
        {
            if (this.Count == 0)
            {
                this.Head = this.Tail = new ListNode<T>(element);
            }
            else
            {
                var newone = new ListNode<T>(element);
                newone.Prev = this.Tail;
                this.Tail.Next = newone;
                this.Tail = newone;
            }
            this.Count++;
        }

        // Прмахване на първи елемент
        public T RemoveFirst()
        {
            var elementoreturn = this.Head.Value;
            this.Head.Prev = null;
            this.Head = this.Head.Next;
            this.Count--;
            return elementoreturn;
        }

        // Премахване на последен елемент
        public T RemoveLast()
        {
            T elementoreturn = this.Tail.Value;
            this.Tail = this.Tail.Prev;
            this.Tail.Next = null;
            this.Count--;
            return elementoreturn;
        }

        // Масив
        public T[] ToArray()
        {
            var curr = this.Head;
            var index = 0;
            var arr = new T[this.Count];
            while (curr != null)
            {
                arr[index++] = curr.Value;
                curr = curr.Next;
            }
            return arr;
        }

        // Нумератор
        public IEnumerator<T> GetEnumerator()
        {
            var current = this.Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
