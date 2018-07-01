using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem22
{
    class CustomArrayList
    {
        private const int INITIAL_CAPACITY = 4;
        private object[] arr; 

        // Брой
        private int count;
        public int Count
        {
            get { return this.count; }
            private set { this.count = value; }
        }

        // Капацитет 
        private int capacity;
        public int Capacity
        {
            get { return this.capacity; }
            private set { this.capacity = value; }
        }

        // Конструктор
        public CustomArrayList(int size = INITIAL_CAPACITY)
        {
            arr = new object[size];
            capacity = size;
            count = 0;
        }

        // Итератор 
        private object this[int index]
        {
            get
            {
                OutOfRange(index);
                return this.arr[index];
            }
            set
            {
                OutOfRange(index);
                this.arr[index] = value;
                this.count++;
            }
        }

        // Добавяне
        public void Add(object item)
        {
            if (capacity == count)
            {
                capacity *= 2; // Разтягане
                object[] temp = arr;
                arr = new object[capacity];
                for (int i = 0; i < temp.Length; i++) arr[i] = temp[i];
                arr[count] = item;
            }
            else arr[count] = item;
            count++;
        }

        // Връща елемент 
        public object Get(int index)
        {
            OutOfRange(index);
            return arr[index];
        }

        // Премахване по индекс
        public object Remove(int index)
        {
            OutOfRange(index);
            var temp = arr[index];
            arr = arr.Take(index).Concat(arr.Skip(index + 1)).ToArray();
            count--;
            return temp;
        }

        // TODO: Премахване по обект
        public int Remove(object item)
        {
            return 42;
        }

        // Добавяне // TO TEST
        public void Insert(int index, object item)
        {
            OutOfRange(index);

            // v1
            //var t1 = arr.Take(index).ToArray();
            //var t2 = new object[1] { item };
            //var t3 = arr.Skip(index).ToArray();
            //arr = t1.Concat(t2.Concat(t3)).ToArray();

            // v2
            arr = arr.Take(index).Concat((new object[1] { item }).Concat(arr.Skip(index))).ToArray();

        }

        public int IndexOf(object item)
        {
            return 42;
        }

        // Изистване 
        public void Clear()
        {
            while (count > 0) Remove(0);
            return;
        }

        public bool Contains(object item)
        {
            return true;
        }


        // Проверка дали сме в границите
        private void OutOfRange(int index)
        {
            if (index < 0 || index > count)
            throw new IndexOutOfRangeException();
        }
    }
}
