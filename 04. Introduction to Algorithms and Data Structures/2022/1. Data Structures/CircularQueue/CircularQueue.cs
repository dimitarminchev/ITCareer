using System.Collections;

namespace CircularQueue
{
    /// <summary>
    /// Кръгова опашка
    /// </summary>
    public class CircularQueue<T> : IEnumerable<T>
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

        /// <summary>
        /// Конструктор
        /// </summary>
        public CircularQueue(int capacity = DefaultCapacity)
        {
            this.elements = new T[capacity];
            this.Count = 0;
        }
       
        /// <summary>
        /// Добавяне на елемент
        /// </summary>
        public void Enqueue(T element) 
        {
            if (this.Count >= this.elements.Length)
            {
                this.Glow();
            }
            this.elements[this.endIndex] = element;
            this.endIndex = (this.endIndex + 1) % this.elements.Length;
            this.Count++;
        }

        // Увеличава капацитета на опашката
        private void Glow()
        {
            var newElements = new T[this.elements.Length * 2];
            this.CopyAllElementsTo(newElements);
            this.elements = newElements;
            this.startIndex = 0;
            this.endIndex = this.Count;
        }

        // Намaлява капацитета на опашката
        private void Shrink()
        {
            var newElements = new T[this.elements.Length / 2];
            this.CopyAllElementsTo(newElements);
            this.elements = newElements;
            this.startIndex = 0;
            this.endIndex = this.Count;
        }

        // Копиране на елементите в нова структура
        private void CopyAllElementsTo(T[] resultArr)
        {
            int sourceIndex = this.startIndex;
            int destinationIndex = 0;
            for (int i = 0; i < this.Count; i++)
            {
                resultArr[destinationIndex] = this.elements[sourceIndex];
                sourceIndex = (sourceIndex + 1) % this.elements.Length;
                destinationIndex++;
            }
        }

        /// <summary>
        /// Премахване на елементи
        /// </summary>
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

        /// <summary>
        /// Преобразуване в масив
        /// </summary>
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
