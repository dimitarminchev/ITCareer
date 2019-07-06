using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Product
    {
        private string name;

        private Product next;

        public Product(string name)
        {
            this.name = name;
        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public Product Next
        {
            set { this.next = value; }
            get { return this.next; }
        }

        public override string ToString()
        {
            return $"Product {this.name}"; 
        }
    }
}
