using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    class Product
    {
        private string name;
        private string barcode;
        private double quantity;
        private double price;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }
        public double Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
