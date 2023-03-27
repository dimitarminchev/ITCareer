namespace CarriageOfGoods
{
    class Freight
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

        private double weight;

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Weight cannot be negative");
                }
                weight = value;
            }
        }

        public Freight(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
    }
}
