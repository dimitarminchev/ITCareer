using System.Collections;

namespace CircularQueue
{
    public class CircularQueue<T> : IEnumerable<T>
    {
        private const int DefaultCapacity = 4;

        public int Count { get; private set; }

        private T[] elements;

        private int startIndex = 0;

        private int endIndex = 0;

        public CircularQueue(int capacity = DefaultCapacity)
        {
            this.elements = new T[capacity];
            this.Count = 0;
        }

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

        private void Glow()
        {
            var newElements = new T[this.elements.Length * 2];
            this.CopyAllElementsTo(newElements);
            this.elements = newElements;
            this.startIndex = 0;
            this.endIndex = this.Count;
        }

        private void Shrink()
        {
            var newElements = new T[this.elements.Length / 2];
            this.CopyAllElementsTo(newElements);
            this.elements = newElements;
            this.startIndex = 0;
            this.endIndex = this.Count;
        }

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

        public T Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Empty!");
            }

            var result = this.elements[this.startIndex];
            this.startIndex = (this.startIndex + 1) % this.elements.Length;
            this.Count--;

            if (this.Count <= this.elements.Length / 2 && this.Count >= DefaultCapacity)
            {
                this.Shrink();
            }

            return result;
        }

        public T[] ToArray()
        {
            T[] result = new T[this.Count];
            int sourceIndex = this.startIndex;
            int destinationIndex = 0;
            for (int i = 0; i < this.Count; i++)
            {
                result[destinationIndex++] = this.elements[sourceIndex];
                sourceIndex = (sourceIndex + 1) % this.elements.Length;
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