namespace BonApetit
{
    public class Product
    {
        private string name;
        private double price;
        private int weight;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid Command!");
                }
                this.name = value;
            }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0.01)
                {
                    throw new ArgumentException("Invalid Command!");
                }
                this.price = value;
            }
        }

        public int Weight
        {
            get { return this.weight; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid Command!");
                }
                this.weight = value;
            }
        }

        public Product(string name, double price, int weight)
        {
            this.Name = name;
            this.Price = price;
            this.Weight = weight;
        }

        public override string ToString()
        {
            return this.Name + " - " + this.Weight;
        }

        public static Product GetCheapestProduct(Dictionary<string, Product> products)
        {
            return products.OrderBy(element => element.Value.Price).First().Value;
        }

    }
}
