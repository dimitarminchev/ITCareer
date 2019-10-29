using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueue
{
    public class CircularQueue<T>
    {
        // Капацитет по подразбиране
        private const int DefaultCapacity = 4;

        // Брой на елементите
        public int Count { get; private set; }

        // Елементи
        private T[] elements;

        // Индекс на първия влязъл елемент в опашката
        private int startIndex = 0;

        // Индекс на последният влязъл елемент в опашката
        private int endIndex = 0;

        // Конструктор
        public CircularQueue(int capacity = DefaultCapacity)
        {
            this.Count = 0;
            this.elements = new T[capacity];
        }

        // Добавя елемент в края на опашката
        public void Enqueue(T element)
        {
            if (this.Count >= this.elements.Length)
            {
                this.Grow();
            }
            this.elements[this.endIndex] = element;
            this.endIndex = (this.endIndex + 1) % this.elements.Length; // Circular
            this.Count++;
        }

        // Увеличава капацитета на опашката
        private void Grow()
        {
            var newElements = new T[2 * this.elements.Length];
            this.CopyAllElements(newElements);
            this.elements = newElements;
            this.startIndex = 0;
            this.endIndex = this.Count;
        }

        // Намaлява капацитета на опашката
        private void Shrink()
        {
            var newElements = new T[this.elements.Length / 2];
            this.CopyAllElements(newElements);
            this.elements = newElements;
            this.startIndex = 0;
            this.endIndex = this.Count;
        }

        // Копиране на елементите в нова структура
        private void CopyAllElements(T[] newElements)
        {
            int sourceIndex = this.startIndex;
            int destinationIndex = 0;
            for (int i = 0; i < this.Count; i++)
            {
                newElements[destinationIndex++] = this.elements[sourceIndex];
                sourceIndex = (sourceIndex + 1) % this.elements.Length; // Circular                
            }
        }

        // Премахване на елементи
        public T Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Empty!");
            }

            // FIFO
            var result = this.elements[this.startIndex];
            this.startIndex = (this.startIndex + 1) % this.elements.Length;
            this.Count--;

            if (this.Count <= this.elements.Length / 2 && this.Count >= DefaultCapacity)
            {
                this.Shrink();
            }

            return result;
        }

        // Преобразуване в масив
        public T[] ToArray()
        {
            T[] result = new T[this.Count];
            int sourceIndex = this.startIndex;
            int destinationIndex = 0;
            for (int i = 0; i < this.Count; i++)
            {
                result[destinationIndex++] = this.elements[sourceIndex];
                sourceIndex = (sourceIndex + 1) % this.elements.Length; // Circular                
            }
            return result;
        }

    }
}
