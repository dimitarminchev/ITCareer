using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Markup;

namespace Knapsack_2._0
{
    // Помощен клас на предмет за раницата
    public class Item
    {
        // Наименование
        public string Name { get; set; }

        // Тегло
        public int Weight { get; set; }

        // Стойност
        public int Value { get; set; }

        // Конструктор
        public Item(string name, int weight, int value)
        {
            this.Name = name;
            this.Weight = weight;
            this.Value = value;
        }

        // Печат
        public override string ToString()
        {
            return $"{this.Name}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Предмети
            List<Item> items = new List<Item>();

            // Входни данни
            Console.Write("Capacity [Example: 7] = ");
            var capacity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Items [name weight value], end to exit:");
            var line = Console.ReadLine();
            while (line != "end")
            {
                var parts = line.Split();
                // Добавяме предмет
                items.Add(new Item(parts[0], int.Parse(parts[1]), int.Parse(parts[2])));
                line = Console.ReadLine();
            }

            // Обработка
            List<Item> takenItems = Knapsack(items.ToArray(), capacity);

            // Изходни данни
            Console.WriteLine("Total Weight: {0}", takenItems.Sum(item => item.Weight));
            Console.WriteLine("Total Value: {0}", takenItems.Sum(item => item.Value));
            Console.WriteLine("Picked Items: {0}", string.Join(", ", takenItems.OrderBy(item => item.Name)));
        }

        private static List<Item> Knapsack(Item[] items, int capacity)
        {
            int[,] values = new int[items.Length + 1, capacity + 1];
            bool[,] IsItemIncluded = new bool[items.Length + 1, capacity + 1];

            // Калкулиране на цените на предметите
            for (int itemIndex = 0; itemIndex < items.Length; itemIndex++)
            {
                int row = itemIndex + 1;
                Item item = items[itemIndex];
                for (int currentCapacity = 1; currentCapacity <= capacity; currentCapacity++)
                {
                    int excludedValue = values[row - 1, currentCapacity];
                    int incudedValue = 0;
                    if (item.Weight <= currentCapacity)
                    {
                        incudedValue = item.Value + values[row - 1, currentCapacity - item.Weight];
                    }
                    if (incudedValue > excludedValue)
                    {
                        values[row, currentCapacity] = incudedValue;
                        IsItemIncluded[row, currentCapacity] = true;
                    }
                    else 
                    {
                        values[row, currentCapacity] = excludedValue;
                    }
                }
            }

            // Връщане на избраните предмети за раницата
            List<Item> takenItems = new List<Item>();
            for (int i = items.Length; i > 0; i--)
            {
                if (!IsItemIncluded[i, capacity]) continue;
                Item item = items[i - 1];
                takenItems.Add(item);
                capacity = capacity - item.Weight;
            }
            return takenItems;
        }
    }
}
