using System.Collections;

namespace ReversedList
{
    /// <summary>
    /// Обратен списък
    /// </summary>
    public class ReversedList<T> : IEnumerable<T>
    {
        // Елементи
        private T[] items;

        /// <summary>
        /// Капацитет
        /// </summary>
        public int Capacity
        {
            get { return capacity; }
            private set { capacity = value; }
        }
        private int capacity;

        /// <summary>
        /// Брой
        /// </summary>
        public int Count
        {
            get { return count; }
            private set { count = value; }
        }
        private int count;

        /// <summary>
        /// Конструктор
        /// </summary>
        public ReversedList(int capacity = 2)
        {
            this.count = 0;
            this.capacity = capacity;
            this.items = new T[capacity];
        }

        /// <summary>
        /// Добавяне на елемент
        /// </summary>
        public void Add(T item)
        {
            // Разширяване
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
            // Добавяне
            this.items[this.Count] = item;
            this.Count++;
        }

        /// <summary>
        /// Премахване на елемент 
        /// </summary>
        public T RemoveAt(int index)
        {
            // Проверка дали сме в границите
            OutOfRange(index);

            T element = this.items[index];

            // Премахване на елемента и получване на нова колекция
            var temp = items.Take(Count).Reverse();
            this.items = temp.Take(index).Concat(temp.Skip(index + 1)).Reverse().Concat(new T[Capacity - Count + 1]).ToArray();
            this.Count--;

            return element;
        }

        /// <summary>
        /// Достъпване на елемент по индекс
        /// </summary>
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

        // Проверка дали сме в границите
        private void OutOfRange(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }
        }

        // Нумератор
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
