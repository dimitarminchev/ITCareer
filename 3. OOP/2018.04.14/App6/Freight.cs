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
        private string name; // Поле
        public string Name // Свойство
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Тегло
        private double weight; // Поле
        public double Weight // Свойство
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        // Конструктор
        public Freight(string name, double weight)
        {
            if (String.IsNullOrEmpty(name))
            throw new Exception("Name cannot be empty");

            if (weight < 0)
            throw new Exception("Weight cannot be negative");

            this.name = name;
            this.weight = weight;
        }
    }
}
