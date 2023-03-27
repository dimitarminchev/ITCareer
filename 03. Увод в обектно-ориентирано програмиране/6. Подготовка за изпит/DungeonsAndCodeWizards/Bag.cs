namespace DungeonsAndCodeWizards
{
    class Bag
    {
        private int capacity = 100;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        private int load;

        public int Load
        {
            get { return Items.Sum(item => item.Weight); }
        }

        private List<Item> items;

        public IReadOnlyList<Item> Items
        {
            get { return items; }
        }

        public void AddItem(Item item)
        {
            if (item.Weight + Load > capacity)
            {
                throw new InvalidOperationException("Bag is full!");
            }
            items.Add(item);
        }

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

        public Bag(int capacity)
        {
            this.Capacity = capacity;
        }
    }
}
