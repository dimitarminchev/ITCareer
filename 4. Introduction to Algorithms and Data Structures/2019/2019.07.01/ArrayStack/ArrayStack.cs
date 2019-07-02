using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStack
{
    public class ArrayStack<T>
    {
        // Елементи
        private T[] elements;

        // Брой елементи
        public int Count { get; private set; }

        // Начален капацитет
        private const int InitialCapacity = 16;

        // Конструктор
        public ArrayStack(int capacity = InitialCapacity)
        {
            this.Count = 0;
            this.elements = new T[capacity];
        }

        // Добавя
        public void Push(T element)
        {
            if (this.Count == this.elements.Length)
            {
                this.Grow();
            }
            this.elements[this.Count] = element;
            this.Count++;
        }

        // Изтриваме
        public T Pop()
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

        // Преобразуване в масив
        public T[] ToArray()
        {
            return this.elements.ToArray();
        }

        // Увеличава капацитета на стека
        private void Grow()
        {
            var newElements = new T[2 * this.elements.Length];
            for (int i = 0; i < this.elements.Length; i++)
            {
                newElements[i] = this.elements[i];
            }
            this.elements = newElements;
        }

        // Намaлява капацитета на стека
        private void Shrink()
        {
            var newElements = new T[this.elements.Length / 2];
            for (int i = 0; i < this.elements.Length / 2; i++)
            {
                newElements[i] = this.elements[i];
            }
            this.elements = newElements;
        }
    }
}
