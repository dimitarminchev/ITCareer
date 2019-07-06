using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class CapacityList
    {
        private const int InitialCapacity = 2;
        private Pair[] items;

        private int startIndex = 0; // показва първият индекс, от който започваме да сумираме текущите елементи
        private int nextIndex = 0; // показва поредният индекс, на който можем да поставим елемент

        public CapacityList(int capacity = InitialCapacity)
        {
            this.items = new Pair[capacity];
            this.Count = 0;
        }

        public int Count
        {
            get;
            private set;
        }

        // Сумирайте двойките от startIndex до nextIndex
        public Pair SumIntervalPairs()
        {
            Pair sum = new Pair(items[startIndex].First, items[startIndex].Last);
            for (int index = startIndex + 1; index < nextIndex; index++)
            {
                sum = new Pair
                (
                    sum.First + items[index].First,
                    sum.Last + items[index].Last,
                    true // Summed
                );
            }
            return sum;
        }

        // Сумирайте двойките от 0 до this.Count – всички двойки, които имат право да участват в класирането
        public Pair Sum()
        {
            int part1 = 0, part2 = 0;
            for (int index = 0; index < this.Count; index++)
            {
                if (this.items[index].Summed == false)
                {
                    part1 += this.items[index].First;
                    part2 += this.items[index].Last;
                }
            }
            return new Pair(part1, part2, true); // Summed
        }

        // Добавяне на двойката 
        public void Add(Pair item)
        {
            // Ако няма място, сумираме всички двойки и ги записваме на едно място
            if (this.nextIndex == this.items.Length)
            {
                int capacity = this.items.Count();

                var newItems = this.items.Where(x => x.Summed == true).ToList();
                newItems.Add(Sum());

                this.items = new Pair[capacity];
                for (int index = 0; index < newItems.Count; index++)
                {
                    this.items[index] = newItems[index];
                }
                this.Count = newItems.Count();
                this.nextIndex = newItems.Count();
            }
            else
            {
                this.items[this.nextIndex] = item;
                this.nextIndex++;
                this.Count++;
            }            
        }

        // Oтпечатване на всички двойки 
        public void PrintCurrentState()
        {
            for (int index = 0; index < this.nextIndex; index++)
            {
                Console.WriteLine(items[index].ToString());
            }
        }

        // Отпечатване на всички сумирани двойки
        public void PrintCurrentPairSum()
        {
            bool printed = false;
            for (int index = 0; index < this.nextIndex; index++)
            {
                if (items[index].Summed == true)
                {
                    Console.WriteLine(items[index].ToString());
                    printed = true;
                }
            }
            if (!printed) Console.WriteLine("(0,0)");
        }

    }
}
