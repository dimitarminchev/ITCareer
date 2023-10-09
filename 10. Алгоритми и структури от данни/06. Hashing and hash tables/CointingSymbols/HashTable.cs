using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CointingSymbols
{
    public class HashTable<TKey, TValue> : IEnumerable<KeyValue<TKey, TValue>>
    {
        private LinkedList<KeyValue<TKey, TValue>>[] slots;

        private const int InitalCapacity = 16;

        private const float LoadFactor = 0.75f;

        public int Count { get; set; }

        public int Capacity { get; set; }

        public HashTable(int capacity = InitalCapacity)
        {
            this.slots = new LinkedList<KeyValue<TKey, TValue>>[capacity];
            this.Capacity = capacity;
            this.Count = 0;
        }

        public void Add(TKey key, TValue value)
        {
            GrowIfNeeded();
            int slotNumber = this.FindSlotNumber(key);
            if (this.slots[slotNumber] == null)
            {
                this.slots[slotNumber] = new LinkedList<KeyValue<TKey, TValue>>();
            }
            foreach (var element in this.slots[slotNumber])
            {
                if (element.Key.Equals(key))
                {
                    throw new ArgumentException("Key already exists: " + key);
                }
            }
            var newElement = new KeyValue<TKey, TValue>(key, value);
            this.slots[slotNumber].AddLast(newElement);
            this.Count++;
        }

        private int FindSlotNumber(TKey key)
        {
            return Math.Abs(key.GetHashCode()) % this.slots.Length;
        }

        private void GrowIfNeeded()
        {
            if ((float)(this.Count + 1) / this.Capacity > LoadFactor)
            {
                Grow();
            }
        }

        private void Grow()
        {
            this.Capacity *= 2;
            var newSlots = new LinkedList<KeyValue<TKey, TValue>>[this.Capacity];
            Array.Copy(slots, 0, newSlots, 0, slots.Length);
            this.slots = newSlots;
        }

        public bool AddOrReplace(TKey key, TValue value)
        {
            if (this.ContainsKey(key))
            {
                int slotNumber = this.FindSlotNumber(key);
                this.Find(key).Value = value;
                return true; 
            }
            this.Add(key, value);
            return false;
        }

        public TValue Get(TKey key)
        {
            int slotNumber = this.FindSlotNumber(key);
            LinkedList<KeyValue<TKey, TValue>> slot = slots[slotNumber];
            if (slot == null)
            {
                throw new ArgumentException("No element at key: " + key);
            }
            KeyValue<TKey, TValue> element = slot.Where(x => x.Key.Equals(key)).FirstOrDefault();
            if (element == null)
            {
                throw new ArgumentException("No element at key: " + key);
            }
            return element.Value;
        }

        public TValue this[TKey key] 
        {
            get
            {
                return this.Get(key);
            }
            set 
            {
                this.AddOrReplace(key, value);
            }
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            int slotNumber = this.FindSlotNumber(key);
            LinkedList<KeyValue<TKey, TValue>> slot = slots[slotNumber];
            if (slot == null)
            {
                value = default(TValue);
                return false;
            }
            KeyValue<TKey, TValue> element = slot.Where(x => x.Key.Equals(key)).FirstOrDefault();
            if (element == null)
            {
                value = default(TValue);
                return false;
            }
            value = element.Value;
            return true;
        }

        public KeyValue<TKey, TValue> Find(TKey key)
        {
            int slotNumber = this.FindSlotNumber(key);
            LinkedList<KeyValue<TKey, TValue>> slot = slots[slotNumber];
            if (slot == null) return null;

            KeyValue<TKey, TValue> element = slot.Where(x => x.Key.Equals(key)).FirstOrDefault();

            return element;
        }

        public bool ContainsKey(TKey key)
        {
            int slotNumber = this.FindSlotNumber(key);
            LinkedList<KeyValue<TKey, TValue>> slot = slots[slotNumber];
            if (slot == null) return false;

            KeyValue<TKey, TValue> element = slot.Where(x => x.Key.Equals(key)).FirstOrDefault();
            if (element == null) return false;

            return true;
        }

        public bool Remove(TKey key)
        {
            int slotNumber = this.FindSlotNumber(key);
            var elementToRemove = this.Find(key);
            if (elementToRemove == null) return false;
            slots[slotNumber].Remove(elementToRemove);
            this.Count--;
            return true;
        }

        public void Clear()
        {
            this.Count = 0;
            this.Capacity = InitalCapacity;
            this.slots = new LinkedList<KeyValue<TKey, TValue>>[this.Capacity];
        }

        public IEnumerable<TKey> Keys
        {
            get { return this.Select(element => element.Key); }
        }

        public IEnumerable<TValue> Values
        {
            get { return this.Select(element => element.Value); }
        }

        public IEnumerator<KeyValue<TKey, TValue>> GetEnumerator()
        {
            foreach (var slot in this.slots)
            {
                if (slot != null)
                {
                    foreach (var item in slot)
                    {
                        yield return item;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
