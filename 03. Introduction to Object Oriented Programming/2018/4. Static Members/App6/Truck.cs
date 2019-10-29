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

        // Добавяне на товар
        public void Add(Freight freight)
        {
            var cargo = this.freights.Sum(x => x.Weight);
            if (this.capacity < freight.Weight + cargo)
            {
                Console.WriteLine($"{this.name} can not loaded {freight.Name}");
            }
            else
            {
                Console.WriteLine($"{this.name} loaded {freight.Name}");
                freights.Add(freight);
            }
        }

        // Печат на товари
        public void Print()
        {
            var cargo = String.Join(", ", this.freights.Select(x => x.Name).ToList());
            if (String.IsNullOrEmpty(cargo)) cargo = "Nothing loaded";
            Console.WriteLine($"{this.Name} - {cargo}");
        }
    }
}
