using System.Collections;

namespace ArrayList
{
    public class ArrayList<T> : IEnumerable<T>
    {
        private T[] items;

        public int Count { get; private set; }

        public int Capacity { get; private set; }

        public ArrayList()
        {
            this.Count = 0;
            this.Capacity = 2;
            this.items = new T[this.Capacity];
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

        public void Add(T item)
        {
            if (this.Count == this.Capacity)
            {
                this.Capacity *= 2;
                var temp = this.items;
                this.items = new T[this.Capacity];
                for (int i = 0; i < temp.Count(); i++)
                {
                    this.items[i] = temp[i];
                }
            }
            this.items[this.Count] = item;
            this.Count++;
        }

        public void Resize()
        {
            T[] copy = new T[this.items.Length * 2];

            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }

            this.items = copy;
        }

        public T RemoveAt(int index)
        {
            OutOfRange(index);

            var item = this.items[index];
            this.items = items.Take(index).Concat(items.Skip(index + 1)).Concat(new T[1]).ToArray();
            this.Count--;

            if (this.items.Count() <= this.Capacity / 2)
            {
                if (this.Count < 2) return item;
                this.Capacity /= 2;
                var temp = this.items;
                this.items = new T[this.Capacity];
                for (int i = 0; i < temp.Count(); i++)
                {
                    this.items[i] = temp[i];
                }
            }

            return item;
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
            for (int i = 0; i < this.items.Count(); i++)
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
