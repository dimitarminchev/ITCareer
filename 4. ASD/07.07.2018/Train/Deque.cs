using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    public class Deque<T> where T : Train
    {
        private static int defaultCapacity = 16;

        private Stack<T> passengerTrains;
        private Stack<T> freightTrains;
        private Stack<T> history;

        public Deque() : this(defaultCapacity) { }

        public Deque(int capacity)
        {
            this.passengerTrains = new Stack<T>(capacity);
            this.freightTrains = new Stack<T>(capacity);
            this.history = new Stack<T>();
            this.Capacity = capacity;
        }

        public Deque(IEnumerable<T> collection)
                : this(collection.Count())
        {
            foreach (var item in collection)
            {
                if (item is Train)
                {
                    Train train = (Train)Convert.ChangeType(item, typeof(Train));
                    if (train.Type == "P")
                    {
                        passengerTrains.Push(item);
                    }
                    else
                    {
                        freightTrains.Push(item);
                    }
                }
            }
        }

        public int Capacity;
        public int Count;

        public void AddFront(T item)
        {
            this.passengerTrains.Push(item);
            this.Count++;
        }

        public void AddBack(T item)
        {
            this.freightTrains.Push(item);
            this.Count++;
        }

        public T RemoveFront()
        {
            if (this.passengerTrains.Count > 0)
            {
                this.Count--;
                this.history.Push(passengerTrains.Peek());
                return this.passengerTrains.Pop();

            }
            return null;
        }

        public T RemoveBack()
        {
            if (this.freightTrains.Count > 0)
            {
                this.Count--;
                this.history.Push(freightTrains.Peek());
                return this.freightTrains.Pop();
            }
            return null;
        }

        public T GetFront()
        {
            if (this.passengerTrains.Count > 0)
            {
                return this.passengerTrains.Peek();
            }
            return null;
        }

        public T GetBack()
        {
            if (this.freightTrains.Count > 0)
            {
                return this.freightTrains.Peek();
            }
            return null;
        }

        public T[] GetHistory()
        {
            return this.history.ToArray();
        }
    }
}
