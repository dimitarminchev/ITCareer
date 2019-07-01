using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndCodeWizards
{
    class Bag
    {
        // Капацитет
        private int capacity = 100;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        // Сума на тегла
        private int load;

        public int Load
        {
            // Sum of the Items weights 
            get { return Items.Sum(item => item.Weight); }
        }

        // Предмети
        private List<Item> items;

        public IReadOnlyList<Item> Items
        {
            get { return items; }
        }

        // Добавяне
        public void AddItem(Item item)
        {
            if (item.Weight + Load > capacity)
            {
                throw new InvalidOperationException("Bag is full!");
            }
            items.Add(item);
        }

        // Извличане
        public Item GetItem(string name)
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Bag is empty!");
            }
            var item = items.FirstOrDefault(a => a.Name == name);
            if (items.Contains(item) == false)
            {
                throw new ArgumentException($"No item with name {name} in bag");
            }
            items.Remove(item);
            return item;
        }

        // Конструктор
        public Bag(int capacity)
        {
            this.Capacity = capacity;
        }
    }
}
