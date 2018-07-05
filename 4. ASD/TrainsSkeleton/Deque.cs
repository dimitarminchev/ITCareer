using System;
using System.Linq;

namespace TrainsSkeleton {
    internal class Deque<T> {
        const int IC = 4;

        public int Count { get; private set; }
        public int Capacity { get; private set; }

        T[] list;

        internal Deque() {
            list = new T[IC];
            Capacity = IC;
        }

        internal void AddBack(T item) {
            if (Capacity == Count) {
                Capacity *= 2;
                Array.Resize(ref list, Capacity);
            }
            list = new T[] { item }.Concat(list.Take(Capacity - 1)).ToArray();
            Count++;
        }

        internal void AddFront(T item) {
            if (Capacity == Count) {
                Capacity *= 2;
                Array.Resize(ref list, Capacity);
            }
            list[Count++] = item;
        }

        internal T GetFront() {
            return list[Count - 1];
        }

        internal T GetBack() {
            return list[0];
        }

        internal T RemoveBack() {
            var item = list[0];
            Count--;
            list = list.Skip(1).Concat(new T[1]).ToArray();
            return item;
        }

        internal T RemoveFront() {
            var item = list[--Count];
            list = list.Take(Count).Concat(list.Skip(Count + 1).Concat(new T[1])).ToArray();
            return item;
        }
    }
}