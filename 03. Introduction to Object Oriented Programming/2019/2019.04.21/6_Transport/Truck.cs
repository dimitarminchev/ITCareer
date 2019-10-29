using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Transport
{
    class Truck
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
                else name = value;
            }
        }

        // Товароносимост 
        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Truck capacity must be positive value.");
                }
                else capacity = value;
            }
        }

        // Товари
        private List<Freight> freights;

        public IReadOnlyList<Freight> Freights
        {
            get { return freights.AsReadOnly(); }
        }

        // Конструктор
        public Truck(string name, int capacity)
        {
            this.freights = new List<Freight>();
            this.Name = name;
            this.Capacity = capacity;
        }

        // Зареждане
        public void Add(Freight freight)
        {
            // Проверка дали камиона има тази товароносимост
            if (this.Capacity < freight.Weight)
            {
                throw new ArgumentException($"{this.Name} can't loaded {freight.Name}");
            }
            else this.freights.Add(freight);
        }

        // Препокриване / Пренаписване на метод
        public override string ToString()
        {

            return this.Name + " - " + string.Join(", ", this.freights.Select(item => item.Name));
        }
    }
}
