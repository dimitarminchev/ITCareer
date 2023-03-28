using System.Collections;

namespace DoublyLinkedList
{
    public class DoubleLinkedList<T> : IEnumerable<T>
    {
        private ListNode<T> Head { get; set; }

        private ListNode<T> Tail { get; set; }

        public int Count { get; private set; }

        public void AddFirst(T element)
        {
            if (this.Count == 0)
            {
                this.Head = this.Tail = new ListNode<T>(element);
            }
            else
            {
                var newone = new ListNode<T>(element);
                newone.Next = this.Head;
                newone.Prev = newone;
                this.Head = newone;
            }
            this.Count++;
        }

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

        public T RemoveFirst()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Empty List!");
            }
            var first = this.Head.Value;
            this.Head = this.Head.Next;
            if (this.Head != null)
            {
                this.Head.Prev = null;
            }
            else
            {
                this.Tail = null;
            }
            this.Count--;
            return first;
        }

        public T RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Empty List!");
            }
            T last = this.Tail.Value;
            this.Tail = this.Tail.Prev;
            this.Tail.Next = null;
            this.Count--;
            return last;
        }

        public T[] ToArray()
        {
            var array = new T[this.Count];
            int index = 0;
            var current = this.Head;
            while (current != null)
            {
                array[index++] = current.Value;
                current = current.Next;
            }
            return array;
        }

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