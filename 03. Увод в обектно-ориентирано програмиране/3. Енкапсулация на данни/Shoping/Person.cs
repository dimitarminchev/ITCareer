namespace Shoping
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }

        private float money;

        public float Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        private List<Product> bag;

        public List<Product> Bag
        {
            get { return bag.AsReadOnly().ToList(); }
        }

        public Person(string name, float money)
        {
            this.bag = new List<Product>();
            this.Name = name;
            this.Money = money;
        }

        public void AddProduct(Product item)
        {
            if (this.Money < item.Price)
            {
                throw new ArgumentException($"{this.Name} can't afford {item.Name}");
            }
            this.Money -= item.Price;
            this.bag.Add(item);
            Console.WriteLine($"{this.Name} bought {item.Name}");
        }

        public override string ToString()
        {
            if (this.Bag.Count == 0) return this.Name + " - Nothing bought";
            else return this.Name + " - " + string.Join(", ", this.bag.Select(x => x.Name));
        }
    }
}
