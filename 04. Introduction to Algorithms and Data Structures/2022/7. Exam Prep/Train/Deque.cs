using System.Collections;

namespace Train
{
    /// <summary>
    /// Единичен възел от динамична структура за данни
    /// </summary>
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Prev { get; set; }
        public Node<T> Next { get; set; }
        public Node(T value, Node<T> prev, Node<T> next)
        {
            Value = value;
            Prev = prev;
            Next = next;
        }
    }

    /// <summary>
    /// Структура за съхранение на чакаши влакове
    /// </summary>
    public class Deque<T> : IList<T>
    {
        private const int defaultCapacity = 16;
        public int Capacity { get; set; }
        public int Count { get; set; }
        private Node<T> Head { get; set; }
        private Node<T> Tail { get; set; }

        private T[] frontBuffer = new T[16];
        private T[] backBuffer = new T[16];

        /// <summary>
        /// Празен конструктор
        /// </summary>
        public Deque(): this(defaultCapacity)
        {
            this.Capacity = defaultCapacity;
        }

        /// <summary>
        /// Конструктор с зададен капацитет
        /// </summary>
        public Deque(int capacity)
        {
            this.Capacity = capacity;
        }

        /// <summary>
        /// КОнструктор който създава структурата с капацитет съответсващ на подадената колекция
        /// </summary>
        /// <param name="collection"></param>
        public Deque(IEnumerable<T> collection) : this(collection.Count())
        {
            ;;
        }

        int ICollection<T>.Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public T this[int index]
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <summary>
        /// Добавяне на елемент отпред
        /// </summary>
        public void AddFront(T item)
        {
            if (this.Head == null)
            {
                this.Head = this.Tail = new Node<T>(item, null, null);
            }
            else
            {
                var node = new Node<T>(item, null, null);
                node.Next = this.Head;
                this.Head.Prev = node;
                this.Head = node;
            }
            this.Count++;
        }

        /// <summary>
        /// Добавяне на елемент отзад
        /// </summary>
        public void AddBack(T item)
        {
            if (this.Head == null)
            {
                this.Head = this.Tail = new Node<T>(item, null, null);
            }
            else 
            {
                var node = new Node<T>(item, null, null);
                node.Prev = this.Tail;
                this.Tail.Next = node;
                this.Tail = node;
            }
            this.Count++;
        }

        /// <summary>
        /// Премахване на елемент отпред
        /// </summary>
        public T RemoveFront()
        {
            var value = this.Head.Value;
            this.Head.Prev = null;
            this.Head = this.Head.Next;
            this.Count--;
            return value;
        }

        /// <summary>
        /// Премахване на елемент отзад
        /// </summary>
        public T RemoveBack()
        {
            var value = this.Tail.Value;
            this.Tail = this.Tail.Prev;
            this.Tail.Next = null;
            this.Count--;
            return value;
        }

        /// <summary>
        /// Връща елемента отпред
        /// </summary>
        public T GetFront()
        {
            return this.Head.Value;
        }

        /// <summary>
        /// Връща елемента отзад
        /// </summary>
        public T GetBack()
        {
            return this.Tail.Value;
        }

        // Имплементираме методите необходими за IList
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
        
        // Позволяване на обхождане на колецията с foreach
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
