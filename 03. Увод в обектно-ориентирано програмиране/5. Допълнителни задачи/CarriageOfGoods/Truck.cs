namespace CarriageOfGoods
{
    class Truck
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
                else name = value;
            }
        }

        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Truck capacity must be positive value.");
                }
                else capacity = value;
            }
        }

        private List<Freight> freights;

        public IReadOnlyList<Freight> Freights
        {
            get { return freights.AsReadOnly(); }
        }

        public Truck(string name, int capacity)
        {
            this.freights = new List<Freight>();
            this.Name = name;
            this.Capacity = capacity;
        }

        public void Add(Freight freight)
        {
            if (this.Capacity < freight.Weight)
            {
                throw new ArgumentException($"{this.Name} can't loaded {freight.Name}");
            }
            else this.freights.Add(freight);
        }

        public override string ToString()
        {
            return this.Name + " - " + string.Join(", ", this.freights.Select(item => item.Name));
        }
    }
}
