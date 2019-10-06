using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageMaster.Products;

namespace StorageMaster.Entities.Vehicles
{
    public abstract class Vehicle
    {
        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        private List<Product> trunk;

        public IReadOnlyCollection<Product> Trunk
        {
            get { return trunk; }
        }
        public bool IsFull
        {
            get
            {
                if (trunk.Select(x => x.Weight).Sum() >= Capacity) return true;
                return false;
            }
        }

        public bool IsEmpty
        {
            get
            {
                if (trunk.Count == 0) return true;
                return false;
            }
        }
        public Vehicle(int capacity)
        {
            trunk = new List<Product>();
            this.Capacity = capacity;
        }
        public void LoadProduct(Product product)
        {
            if (IsFull) throw new InvalidOperationException("Vehicle is full!");
            trunk.Add(product);
        }
        public Product Unload()
        {
            if (IsEmpty) throw new InvalidOperationException("No products left in vehicle!");
            var lastProduct = trunk.Last();
            trunk.Remove(lastProduct);
            return lastProduct;
        }
    }
}
