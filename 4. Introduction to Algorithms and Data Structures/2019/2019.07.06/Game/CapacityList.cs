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
            return new Pair(part1, part2);
        }

        // Добавяне на двойката 
        public void Add(Pair item)
        {
            // Ако няма масто, сумираме всички двойки и ги записваме на 1 място
            if (this.nextIndex == this.items.Length)
            {
                var pair = SumIntervalPairs();
                this.items = new Pair[InitialCapacity];
                this.items[0] = pair;
                this.Count = 1;
                this.nextIndex = 1;
            }
            else
            {
                this.items[this.nextIndex] = item;
                this.nextIndex++;
                this.Count++;
            }            
        }

        // Oтпечатайте всички двойки от 0 до nextIndex
        public void PrintCurrentState()
        {
            for (int index = 0; index < this.nextIndex; index++)
            {
                Console.WriteLine(items[index].ToString());
            }
        }

        // Мега яката магия
        public void CurrentPairSum()
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
