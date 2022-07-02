using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    /// <summary>
    /// Структура за данни 
    /// </summary>
    public class CapacityList
    {
        private const int InitialCapacity = 2;
        private Pair[] items;

        private int startIndex = 0; // показва първият индекс, от който започваме да сумираме текущите елементи
        private int nextIndex = 0; // показва поредният индекс, на който можем да поставим елемент

        public int Count { get; private set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public CapacityList(int capacity = InitialCapacity)
        {
            this.items = new Pair[capacity];
            this.Count = 0;
        }

        /// <summary>
        /// сумирайте двойките от startIndex до nextIndex
        /// </summary>
        public Pair SumIntervalPairs()
        {
            Pair sum = new Pair(items[startIndex].First, items[startIndex].Last);
            for (int i = startIndex + 1; i < nextIndex; i++)
            {
                sum = new Pair
                (
                    sum.First + items[i].First,
                    sum.Last + items[i].Last,
                    true // Summed
                );
            }
            return sum;
        }

        /// <summary>
        /// сумирайте двойките от 0 до this.Count – всички двойки, които имат право да участват в класирането
        /// </summary>
        public Pair Sum()
        {
            int part1 = 0, part2 = 0;
            for (int i = 0; i < this.Count; i++)
            {
                if (this.items[i].Summmed == false)
                {
                    part1 += items[i].First;
                    part2 += items[i].Last;
                }
            }
            return new Pair(part1, part2, true); // Summed
        }

        /// <summary>
        /// Добавяне на двойката        
        /// </summary>
        public void Add(Pair item)
        {
            // Ако няма място, то сумираме всички двойки и ги записваме на едно място
            if (nextIndex == items.Length)
            {
                int capacity = items.Count();

                var newItems = this.items.Where(x => x.Summmed == true).ToList();
                newItems.Add(Sum());
                newItems.Add(item);

                items = new Pair[capacity];
                for (int i = 0; i < newItems.Count; i++)
                {
                    items[i] = newItems[i];
                }
                Count = newItems.Count();
                nextIndex = newItems.Count();
            }
            else
            {
                items[nextIndex] = item;
                nextIndex++;
                Count++;
            }
        }

        /// <summary>
        /// отпечатайте всички двойки от 0 до nextIndex
        /// </summary>
        public void PrintCurrentState()
        {
            for (int i = 0; i < nextIndex; i++)
            {
                Console.WriteLine(items[i].ToString());
            }
        }

        public void PrintCurrentStateSum()
        {
            bool printed = false;
            for (int i = 0; i < nextIndex; i++)
            {
                if (items[i].Summmed == true)
                {
                    Console.WriteLine(items[i].ToString());
                    printed = true;
                }
            }
            if (!printed) Console.WriteLine("(0,0)");
        }
    }
}
