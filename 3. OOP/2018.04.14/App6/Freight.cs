using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App6
{
    // Товар
    class Freight
    {
        // Име
        private string name; 
        public string Name 
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Тегло
        private double weight; 
        public double Weight 
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
    }
}
