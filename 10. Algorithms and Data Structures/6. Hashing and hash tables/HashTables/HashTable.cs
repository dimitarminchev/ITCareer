using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    public class HashTable<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        private LinkedList<KeyValuePair<TKey, TValue>>[] slots;
        public const int InitialCapacity = 16;
        public const float LoadFactor = 0.75f;
        public int Count { get; private set; }
        public int Capacity { get; private set; }

        public HashTable()
        {
            this.Capacity = InitialCapacity;
            this.slots = new LinkedList<KeyValuePair<TKey, TValue>>[Capacity];
            this.Count = 0;
        }

        public HashTable(int capacity)
        {
            this.Capacity = capacity;
            this.slots = new LinkedList<KeyValuePair<TKey, TValue>>[Capacity];
            this.Count = 0;
        }
        
        public void Add(TKey key, TValue value)
        {
            GrowIfNeeded();
            int slotNumber = this.FindSlotNumber(key);
            if(this.slots[slotNumber] == null)
            {
                this.slots[slotNumber] = new LinkedList<KeyValuePair<TKey, TValue>>();
            }
            foreach(var element in this.slots[slotNumber])
            {
                if(element.Key.Equals(key))
                {
                    throw new ArgumentException("Key already exists: " + key);
                }
            }
            var newElement = new KeyValuePair<TKey, TValue>(key, value);
            this.slots[slotNumber].AddLast(newElement);
            this.Count++;
        }

        public bool AddOrReplace(TKey key, TValue value)
        {
            if(this.ContainsKey(key))
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
            LinkedList<KeyValuePair<TKey, TValue>> slot = slots[slotNumber];
            if (slot == null)
            {
                throw new ArgumentException("No element corresponding to the key: " + key);
            }

            KeyValuePair<TKey, TValue>
                keyValuePair =
                 slot
                .Where(x => x.Key.Equals(key))
                .FirstOrDefault();

            if(keyValuePair == null)
            {
                throw new ArgumentException("No element corresponding to the key: " + key);
            }
            return keyValuePair.Value;
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
            LinkedList<KeyValuePair<TKey, TValue>> slot = slots[slotNumber];
            if (slot == null)
            {
                value = default(TValue);
                return false;
            }

            KeyValuePair<TKey, TValue>
                keyValuePair =
                 slot
                .Where(x => x.Key.Equals(key))
                .FirstOrDefault();

            if (keyValuePair == null)
            {
                value = default(TValue);
                return false;
            }

            value = keyValuePair.Value;
            return true;
        }

        public KeyValuePair<TKey, TValue> Find(TKey key)
        {
            int slotNumber = this.FindSlotNumber(key);
            LinkedList<KeyValuePair<TKey, TValue>> slot = slots[slotNumber];
            if (slot == null) return null;

            KeyValuePair<TKey, TValue>
                keyValuePair =
                 slot
                .Where(x => x.Key.Equals(key))
                .FirstOrDefault();

            return keyValuePair;
        }

        public bool ContainsKey(TKey key)
        {
            int slotNumber = this.FindSlotNumber(key);
            LinkedList<KeyValuePair<TKey, TValue>> slot = slots[slotNumber];
            if(slot == null) return false;
            
            KeyValuePair<TKey, TValue>
                keyValuePair =
                 slot
                .Where(x => x.Key.Equals(key))
                .FirstOrDefault();

            if (keyValuePair == null)
            {
                return false;
            }
            return true;
        }

        public bool Remove(TKey key)
        {
            int slotNumber = this.FindSlotNumber(key);
            var keyValuePairToRemove = Find(key);
            if(keyValuePairToRemove == null)
            {
                return false;
            }
            slots[slotNumber].Remove(keyValuePairToRemove);
            Count--;
            return true;
        }

        public void Clear()
        {
            this.Count = 0;
            this.Capacity = InitialCapacity;
            this.slots = new LinkedList<KeyValuePair<TKey, TValue>>[Capacity];
        }

        public IEnumerable<TKey> Keys
        {
            get
            {
                return this.Select(x => x.Key);
            }
        }

        public IEnumerable<TValue> Values
        {
            get
            {
                return this.Select(x => x.Value);
            }
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            foreach (var elementList in this.slots)
            {
                if (elementList != null)
                {
                    foreach (var keyValuePair in elementList)
                    {
                        yield return keyValuePair;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator(); 
        }
        
        private void Grow()
        {
            this.Capacity *= 2;
            var newSlots = new LinkedList<KeyValuePair<TKey, TValue>>[Capacity];
            Array.Copy(slots, 0, newSlots, 0, slots.Length);
            slots = newSlots;
        }

        private void GrowIfNeeded()
        {
            if((float)(this.Count + 1) / this.Capacity > LoadFactor)
            {
                this.Grow();
            }
        }
        
        private int FindSlotNumber(TKey key)
        {
            int slotNumber = Math.Abs(key.GetHashCode()) % Capacity;
            return slotNumber;
        }
    }
}
