using System;

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
            Console.WriteLine("Hello World!");
        }
    }
}
