using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem25
{
    class ReversedList<T> : IEnumerable<T>
    {
        private const int INITAL_CAPACITY = 2;
        public int Count { get; private set; }
        public int Capacity { get; private set; }
        public T[] Items;

        // Конструктор
        public ReversedList()
        {
            this.Capacity = INITAL_CAPACITY;
            this.Items = new T[this.Capacity];
        }

        // Итератор
        private T this[int index]
        {
            get
            {
                OutOfRange(index);
                return this.Items[index];
            }
            set
            {
                OutOfRange(index);
                this.Items[index] = value;
            }
        }

        // Добавяне
        public void Add(T element)
        {
            if (this.Capacity == this.Count)
            {
                Capacity *= 2; // Expand
                T[] temp = new T[Capacity];
                for (int i = 0; i < this.Count; i++) temp[i] = this.Items[i];
                this.Items = temp;
            }
            this.Items[this.Count++] = element;
        }

        // Изтриване
        public T RemoveAt(int index)
        {
            OutOfRange(index);
            T element = this.Items[index];
            Items = Items.Take(index).Concat(Items.Skip(index + 1)).ToArray();
            this.Count--;
            // TODO: Additionn Feature: Shrink
            return element;
        }

        // Проверка на индекса
        private void OutOfRange(int index)
        {
            if (index < 0 || index > Count)
            throw new IndexOutOfRangeException();
        }

        // Нумератор
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            yield return Items[i]; 
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
