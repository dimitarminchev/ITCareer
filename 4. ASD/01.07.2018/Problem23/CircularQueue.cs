using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem23
{
    class CircularQueue<T>
    {
        private const int DefaultCapacity = 16;
        private T[] elements;
        private int startIndex = 0;
        private int endIndex = 0;


        public CircularQueue(int capacity = DefaultCapacity)
        {
            this.elements = new T[capacity];
        }

        public int Count { get; private set; }       
        public void Enqueue(T element)
        {
            if (this.Count >= this.elements.Length)
            {
                this.Grow();
            }
            this.elements[this.endIndex] = element;
            this.endIndex = (this.endIndex + 1) % this.elements.Length;
            this.Count++;
        }

        private void Grow()
        {
            T [] newArray = new T[this.elements.Length * 2];
            CopyAllElements(newArray);
            this.elements = newArray;
        }

        private void CopyAllElements(T[] newArray)
        {
            for (int i = this.endIndex-1; i >= 0; i--)
            {
                newArray[i] = this.elements[i];
            }

            for (int i = this.startIndex; i <=this.elements.Length-1; i++)
            {
                newArray[i] = this.elements[i];
            }
        }

         public T Dequeue()
         {
            var dequeueElement = this.elements[this.startIndex];
            this.elements[this.startIndex] = default(T);
            this.Count--;
            return dequeueElement;
            
         }
         public T[] ToArray()
         {
            T[] queueAsArray = new T[this.Count];
            for (int i = this.endIndex; i <=0; i--)
            {
                queueAsArray[i] = this.elements[i];
            }
            for (int i = this.elements.Length - 1; i >=startIndex ; i--)
            {
                queueAsArray[i] = this.elements[i];
            }

            return queueAsArray;
         }

    }
}
