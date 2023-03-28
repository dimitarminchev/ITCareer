using System.Collections;

namespace ArrayStack
{
    public class ArrayStack<T> : IEnumerable<T>
    {
        private T[] elements;

        public int Count { get; private set; }

        private const int InitialCapacity = 2;

        public ArrayStack(int capacity = InitialCapacity)
        {
            this.elements = new T[capacity];
            this.Count = 0;
        }

        public void Push(T element)
        {
            if (this.Count == this.elements.Length)
            {
                this.Grow();
            }
            this.elements[this.Count] = element;
            this.Count++;
        }

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

        public T[] ToArray()
        {
            return this.elements.ToArray();
        }

        private void Grow()
        {
            T[] copy = new T[this.elements.Length * 2];
            for (int i = 0; i < this.elements.Length; i++)
            {
                copy[i] = this.elements[i];
            }
            this.elements = copy;
        }

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