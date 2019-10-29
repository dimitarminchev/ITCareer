using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Prev { get; set; }
        public Node<T> Next { get; set; }
        public Node(T Value)
        {
            this.Value = Value;
            this.Next = null;
            this.Prev = null;
        }
    }

    public class Deque<T> : IList<T>
    {
        private const int defaultCapacity = 16;

        private Node<T> Head { get; set; }

        private Node<T> Tail { get; set; }

        public int Capacity { get; private set; }
        public int Count { get; private set; }

        // празен конструктор, задава капацитета на дека на стойността по подразбиране (16)
        public Deque() : this(defaultCapacity)
        {
            this.Capacity = defaultCapacity;            
        }

        // създава дека с точно зададен капацитет
        public Deque(int capacity)
        {            
            this.Capacity = capacity;
        }
        public Deque(IEnumerable<T> collection) : this(collection.Count())
        {
            //създава дека с капацитет съответстващ на посочената колекция и прехвърля елементите от колекцията в дека
        }
       

        int ICollection<T>.Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public T this[int index]
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        // добавя елемент отпред
        public void AddFront(T item)
        {
            if (Count == 0)
            {
                this.Head = this.Tail = new Node<T>(item);
            }
            else
            {
                var newone = new Node<T>(item);
                newone.Next = this.Head;
                this.Head.Prev = newone;
                this.Head = newone;
            }
            this.Count++;
        }

        // добавя елемент отзад
        public void AddBack(T item)
        {
            if (this.Count == 0)
            {
                this.Head = this.Tail = new Node<T>(item);
            }
            else
            {
                var newone = new Node<T>(item);
                newone.Prev = this.Tail;
                this.Tail.Next = newone;
                this.Tail = newone;
            }
            this.Count++;
        }

        // връща и премахва елемента отпред
        public T RemoveFront()
        {
            var item = this.Head.Value;
            this.Head.Prev = null;
            this.Head = this.Head.Next;
            this.Count--;
            return item;
        }

        // връща и премахва елемента отзад
        public T RemoveBack()
        {
            T item = this.Tail.Value;
            this.Tail = this.Tail.Prev;
            this.Tail.Next = null;
            this.Count--;
            return item;
        }

        // връща, без да премахва, елемента отпред
        public T GetFront()
        {
            return this.Head.Value;
        }

        // връща, без да премахва, елемента отзад
        public T GetBack()
        {            
            return this.Tail.Value;
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
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
