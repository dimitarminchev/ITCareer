using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public class ArrayList<T>
    {
        private const int INITIAL_SIZE = 2;
        private T[] items;

        // Брой
        private int length;
        public int Length
        {
            get { return this.length; }
            private set { this.length = value; }
        }

        // Капацитет 
        private int capacity;
        public int Capacity
        {
            get { return this.capacity; }
            private set { this.capacity = value; }
        }

        // Конструктор
        public ArrayList(int size = INITIAL_SIZE)
        {
            this.capacity = size;
            this.length = 0;
            this.items = new T[size];
        }

        // Итератор
        private T this[int index]
        {
            get
            {
                OutOfRange(index);
                return this.items[index];
            }
            set
            {
                OutOfRange(index);
                this.items[index] = value;
                this.length++;
            }
        }

        // Добавяне
        public void Add(T item)
        {
            if (capacity == length)
            {
                capacity *= 2; // Разтягане
                T[] temp = items;
                items = new T[capacity];
                for (int i = 0; i < temp.Length; i++) items[i] = temp[i];
                items[length] = item;
            }
            else items[length] = item;
            length++;
        }

        // Връща елемент
        public T Get(int index)
        {
            OutOfRange(index);
            return items[index];
        }

        // Промяна на елемент
        public void Set(int index, T item)
        {
            OutOfRange(index);
            items[index] = item;
        }

        // Премахване
        public T RemoveAt(int index)
        {
            OutOfRange(index);
            var temp = items[index];
            items = items.Take(index).Concat(items.Skip(index + 1)).ToArray();
            length--;
            return temp;
        }

        // Проверка дали сме границите
        private void OutOfRange(int index)
        {
            if (index < 0 || index > length)
            throw new IndexOutOfRangeException();
        }
    }
}
