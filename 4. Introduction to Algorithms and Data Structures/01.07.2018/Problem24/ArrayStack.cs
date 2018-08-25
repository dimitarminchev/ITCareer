using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem24
{
    class ArrayStack<T>
    {
        private T[] elements;
        public int Count { get; private set; }
        private const int InitialCapacity = 16;
        public ArrayStack(int capacity = InitialCapacity)
        {
            elements = new T[capacity];
        }
        public void Push(T element)
        {
            if (this.Count == this.elements.Length) this.Grow();
            this.elements[this.Count] = element;
            this.Count++;
        }
        public T Pop()
        {
            if (this.Count == 0) throw new InvalidOperationException();
            T finalValue = this.elements[this.Count - 1];
            this.Count--;
            return finalValue;
        }
        public T[] ToArray()
        {
            var arr = new T[this.Count];
            CopyElements(arr);
            return arr;
        }
        private void Grow()
        {
            var newElements = new T[this.elements.Length *2];
            CopyElements(newElements);
            this.elements = newElements;
        }

        private void CopyElements(T[] newElements)
        {
            for (int i = 0; i < this.Count; i++)
            {
                newElements[i] = this.elements[i];
            }
        }
    }
}
