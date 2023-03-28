using System.Collections;

namespace ReversedList
{
    public class ReversedList<T> : IEnumerable<T>
    {
        private T[] items;

        public int Capacity
        {
            get { return capacity; }
            private set { capacity = value; }
        }
        private int capacity;

        public int Count
        {
            get { return count; }
            private set { count = value; }
        }
        private int count;

        public ReversedList(int capacity = 2)
        {
            this.count = 0;
            this.capacity = capacity;
            this.items = new T[capacity];
        }

        public void Add(T item)
        {
            if (this.Capacity == this.Count)
            {
                this.Capacity *= 2;
                T[] temp = new T[Capacity];
                for (int i = 0; i < this.Count; i++)
                {
                    temp[i] = this.items[i];
                }
                this.items = temp;
            }

            this.items[this.Count] = item;
            this.Count++;
        }

        public T RemoveAt(int index)
        {
            OutOfRange(index);

            T element = this.items[index];

            var temp = items.Take(Count).Reverse();
            this.items = temp.Take(index).Concat(temp.Skip(index + 1)).Reverse().Concat(new T[Capacity - Count + 1]).ToArray();
            this.Count--;

            return element;
        }

        public T this[int index]
        {
            get
            {
                OutOfRange(index);
                return items[index];
            }
            set
            {
                OutOfRange(index);
                this.items[index] = value;
            }
        }

        private void OutOfRange(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}