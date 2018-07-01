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
        public T this[int index]
        {
            get
            {
                if (index < 0 || index > length)
                throw new IndexOutOfRangeException();
                return this.items[index];
            }
            set
            {
                if (index < 0 || index > length)
                throw new IndexOutOfRangeException();
                this.items[index] = value;
                this.length++;
            }
        }
/*
        public void Add(T item) { }
        public T Get(int index) { }
        public void Set(int index, T item) { }
        public T RemoveAt(int index) { }
*/
    }
}
