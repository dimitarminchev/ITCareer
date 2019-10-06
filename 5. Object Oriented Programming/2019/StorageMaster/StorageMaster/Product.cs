using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster.Products
{
    public abstract class Product
    {
        private double price;

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0) throw new InvalidOperationException("Price cannot be negative!");
                price = value;
            }
        }

        private double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Product(double price, double weight)
        {
            this.Price = price;
            this.Weight = weight;
        }
    }
}
