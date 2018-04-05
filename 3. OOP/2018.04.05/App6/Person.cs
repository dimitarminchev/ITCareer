using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App6
{
    class Person
    {
        private string name;
        private double money;
        private List<string> products;

        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            products = new List<string>();
        }
        public double Money
        {
            get { return money; }
            private set
            {
                if (value < 0) throw new ArgumentException("Money cannot be negative");
                money = value;
            }
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if (name == string.Empty) throw new ArgumentException("Name cannot be empty");
                name = value;
            }
        }
        public List<string> Products
        {
            get { return products; }
        }
        public void Buy(string product, List<Product> available)
        {
            int index = 0;
            for (int i = 0; i < available.Count; i++)
                if (available[i].Name == product)
                    index = i;

            if (available[index].Price <= money)
            {
                products.Add(product);
                money -= available[index].Price;
            }
            else Console.WriteLine($"{name} can't afford {product}");
        }
    }
}
