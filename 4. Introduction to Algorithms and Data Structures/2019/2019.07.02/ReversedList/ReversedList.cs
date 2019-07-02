using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedList
{
    public class ReversedList<T> : IEnumerable<T>
    {
        // Елементи
        private T[] items;

        // Капацитет
        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            private set { capacity = value; }
        }


        // Брой
        private int count;

        public int Count
        {
            get { return count; }
            private set { count = value; }
        }

        // Конструктор
        public ReversedList(int capacity = 2)
        {
            this.capacity = capacity;
            this.count = 0;
            this.items = new T[capacity];
        }

        // Достъп по индекс до елемент
        private T this[int index]
        {
            get
            {
                this.OutOfRange(index);
                return this.items[index];
            }
            set
            {
                this.OutOfRange(index);
                this.items[index] = value;
            }
        }

        // Проверка за валидност на индекса
        private void OutOfRange(int index)
        {
            if (index < 0 || index > this.Count)
            {
                throw new IndexOutOfRangeException();
            }
        }

        // Добавяне 
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

        // Итриване
        public T RemoveAt(int index)
        {
            this.OutOfRange(index);
            T element = this.items[index];

            // Премахване на елемента и получване на нова колекция
            var temp = items.Take(Count).Reverse();
            this.items = temp.Take(index).Concat(temp.Skip(index + 1)).Reverse().Concat(new T[Capacity - Count + 1]).ToArray();

            return element;
        }

        // Нумератор
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
