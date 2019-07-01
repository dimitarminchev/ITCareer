using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public class ArrayList<T> 
    {
        // Масив
        private T[] items;

        /// <summary>
        /// Брой на елементите
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Капацитет
        /// </summary>
        public int Capacity { get; private set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public ArrayList()
        {
            this.Count = 0;
            this.Capacity = 2;
            this.items = new T[this.Capacity]; 
        }

        /// <summary>
        /// Достъпване на елемент по индекс
        /// </summary>
        public T this[int index]
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
            }
        }

        /// <summary>
        /// Добавяне на елемент
        /// </summary>
        public void Add(T item)
        {
            // Разширяване
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

        /// <summary>
        /// Взимане на елемент
        /// </summary>
        public T Get(int index)
        {
            OutOfRange(index);
            return this.items[index];
        }

        /// <summary>
        /// Задаване на стойност
        /// </summary>
        public void Set(int index, T item)
        {
            OutOfRange(index);
            this.items[index] = item;
        }

        /// <summary>
        /// Премахваме определен индекс
        /// </summary>
        public T RemoveAt(int index)
        {
            OutOfRange(index);
            var item = this.items[index];                         
            this.items = items.Take(index).Concat(items.Skip(index + 1)).Concat(new T[1]).ToArray(); 
            this.Count--;
            // Свиване
            if (this.items.Count() <= this.Capacity/2)
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

        // Проверка дали сме в границите
        private void OutOfRange(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
