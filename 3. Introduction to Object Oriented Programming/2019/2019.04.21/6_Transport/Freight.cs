using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Transport
{
    // Товар
    class Freight
    {
        // Име
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

        // Тегло
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

        // Конструктор
        public Freight(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

    }
}
