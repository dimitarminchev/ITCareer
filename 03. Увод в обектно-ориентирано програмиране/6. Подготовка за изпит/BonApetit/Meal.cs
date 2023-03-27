namespace BonApetit
{
    class Meal
    {
        private string name;
        private string type;
        private double price;
        private List<Product> products = new List<Product>();
        private int ordered = 0;

        public Meal(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }

        public Meal(string name, string type, List<Product> products)
        {
            this.Name = name;
            this.Type = type;
            this.products = products;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid Command!");
                }
                this.name = value;
            }
        }

        private string Type
        {
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Invalid Command!");
                }
                this.type = value;
            }
        }
        public double Price
        {
            get
            {
                this.price = CalculatePrice();
                return this.price;
            }
        }

        public int Ordered
        {
            get { return this.ordered; }
        }

        public void AddProduct(Product p)
        {
            products.Add(p);
        }

        public bool ContainsProduct(string name)
        {
            return products.Exists(element => element.Name == name);
        }

        public double CalculatePrice()
        {
            return this.products.Sum(element => element.Price) + this.products.Sum(element => element.Price) * 0.30;
        }

        public void PrintRecipe()
        {
            Console.WriteLine(new String('-', 25));
            Console.WriteLine(this.name + " RECIPE");
            Console.WriteLine(new String('-', 25));
            products.ForEach(element => Console.WriteLine(element.ToString()));
            Console.WriteLine(new String('-', 25));
        }

        public void Order()
        {
            this.ordered++;
        }

        public static Meal GetSpecialty(Dictionary<string, Meal> meals)
        {
            return meals.OrderByDescending(element => element.Value.ordered).First().Value;
        }

        public static Meal RecommendByPrice(double price, Dictionary<string, Meal> meals)
        {
            return meals.Where(element => (element.Value.Price <= price))
                .OrderByDescending(element => element.Value.Price).First().Value;
        }

        public static Meal RecommendByPriceAndType(double price, string type, Dictionary<string, Meal> meals)
        {
            return meals.Where(element => (element.Value.Price <= price) && (element.Value.type == type))
                .OrderByDescending(element => element.Value.Price).First().Value;
        }

        public override string ToString()
        {
            return this.name + " - " + this.type;
        }


    }
}
