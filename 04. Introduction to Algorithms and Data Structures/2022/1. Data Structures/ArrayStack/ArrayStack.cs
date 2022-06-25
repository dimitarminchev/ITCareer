using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStack
{
    /// <summary>
    /// Разтеглив стек
    /// </summary>
    public class ArrayStack<T> : IEnumerable<T>
    {
        // Елементи
        private T[] elements;

        // Брой елементи
        public int Count { get; private set;  }

        // Начален капацитет
        private const int InitialCapacity = 2;

        /// <summary>
        /// Конструктор
        /// </summary>
        public ArrayStack(int capacity = InitialCapacity)
        {
            this.elements = new T[capacity];
            this.Count = 0;
        }

        /// <summary>
        /// Добавяне на елемент
        /// </summary>
        public void Push(T element)
        {
            if (this.Count == this.elements.Length)
            {
                this.Grow();
            }
            this.elements[this.Count] = element;
            this.Count++;
        }

        /// <summary>
        /// Изваждане на елемент
        /// </summary>
        public T Pop(T element)
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Empty!");
            }

            var item = this.elements[this.Count - 1];
            this.Count--;

            if (this.Count <= this.elements.Length / 2 && this.Count >= InitialCapacity)
            {
                this.Shrink();
            }

            return item;
        }

        /// <summary>
        /// Превръщане в масив
        /// </summary>
        public T[] ToArray()
        {
            return this.elements.ToArray();
        }

        /// <summary>
        /// Увеличаване на размера на стека
        /// </summary>
        private void Grow()
        {
            T[] copy = new T[this.elements.Length * 2];
            for (int i = 0; i < this.elements.Length; i++)
            {
                copy[i] = this.elements[i];
            }
            this.elements = copy;
        }

        /// <summary>
        /// Намаляване на размера на стека
        /// </summary>
        private void Shrink()
        {
            T[] copy = new T[this.elements.Length / 2];
            for (int i = 0; i < this.elements.Length / 2; i++)
            {
                copy[i] = this.elements[i];
            }
            this.elements = copy;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.elements.Count(); i++)
            {
                yield return this.elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
