using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorSkeleton
{
    class CapacityList
    {
        private const int InitialCapacity = 2;
        private Color[] items;

        private int startIndex = 0;
        private int nextIndex = 0;

        public CapacityList(int capacity = InitialCapacity)
        {
            this.items = new Color[capacity];
        }

        public int Count
        {
            get;
            private set;
        }

        public Color SumIntervalPairs(Color firstColor, int i)
        {
            Color newColor = new Color();
            newColor.Red = (firstColor.Red + items[i].Red)%256;
            newColor.Green = (firstColor.Green + items[i].Green)%256;
            newColor.Blue = (firstColor.Blue + items[i].Blue)%256;
            return newColor;
        }

        public Color Sum()
        {
            Color newColor= new Color(0,0,0);
            for (int i = 0; i < startIndex; i++)
            {
                newColor = SumIntervalPairs(newColor, i);
            }
            return newColor;
        }

        public Color New()
        {
            Color newColor = new Color(0, 0, 0);
            if (nextIndex == items.Length)
            {
                for (int i = startIndex; i < items.Length; i++)
                {
                    newColor = SumIntervalPairs(newColor, i);
                }
            }
            return newColor;
        }

        public Color[] Sort()
        {
            Color[] sorted = items.Take(startIndex).ToArray();
            for (int i = 0; i <= startIndex; i++)
            {
                for (int k = i; k < startIndex - 1; k++)
                {
                    if (sorted[k].CalculatePoints() < sorted[k + 1].CalculatePoints())
                    {
                        Color swap = sorted[k];
                        sorted[k] = sorted[k + 1];
                        sorted[k + 1] = swap;
                    }
                }
            }
            return sorted;
        }

        public void Add(Color item)
        {
            if (nextIndex < items.Length)
            {
                items[nextIndex] = item;
                nextIndex++;
                if (nextIndex ==items.Length )
                {
                    items[startIndex] = New();
                    startIndex++;
                    for (int i = startIndex; i < items.Length; i++)
                    {
                        items[i] = null;
                    }
                    nextIndex = startIndex;
                }
            }
        }

        public void PrintCurrentState()
        {
            for(int i=0;i<nextIndex;i++)
            {
                Console.WriteLine(items[i].ToString());
            }
        }
    }

}
