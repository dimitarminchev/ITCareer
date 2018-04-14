using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App6
{
    // Камион
    class Truck
    {
        // Име
        private string name;
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        // Товароносимост
        private int capacity;
        public int Capacity
        {
            set { this.capacity = value; }
            get { return this.capacity; }
        }

        // Списък с товари
        private List<Freight> freights = new List<Freight>();
        public List<Freight> Freights
        {
            get { return this.freights;  }
            set { this.freights = value;  }
        }

        // Добавяне на товари
        public void Add(Freight item)
        {
            if (this.capacity < item.Weight)
                Console.WriteLine($"{this.name} can't loaded {item.Name}");
            else
            {
                Console.WriteLine($"{this.name} loaded {item.Name}");
                freights.Add(item);
            }
        }
    }
}
