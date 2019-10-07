using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageMaster.Entities.Vehicles;
using StorageMaster.Products;

namespace StorageMaster.Storage
{
    public abstract class Storage
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        private int garageSlots;

        public int GarageSlots
        {
            get { return garageSlots; }
            set { garageSlots = value; }
        }

        public bool IsFull
        {
            get
            {
                if (products != null)
                    if (products.Where(x => x != null).Select(x => x.Weight).Sum() >= capacity) return true;
                return false;
            }
        }
        private Vehicle[] garage;

        public IReadOnlyCollection<Vehicle> Garage
        {
            get { return garage; }
        }
        private Product[] products;

        public IReadOnlyCollection<Product> Products
        {
            get { return products; }
        }
        public Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            Name = name;
            Capacity = capacity;
            GarageSlots = garageSlots;
            garage = new Vehicle[GarageSlots];
            products = new Product[capacity+1];
            for (int i = 0; i < vehicles.Count(); i++)
            {
                garage[i] = vehicles.ToArray()[i];
            }

        }
        public Vehicle GetVehicle(int garageSlot)
        {
            if (garageSlot >= garageSlots) throw new InvalidOperationException("Invalid garage slot!");
            if (garage[garageSlot] == null) throw new InvalidOperationException("No vehicle in this garage slot!");
            return garage[garageSlot];
        }
        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {

            var vehicle = GetVehicle(garageSlot);
            if (deliveryLocation.Garage.Where(x => x == null).Count() <= 0) throw new InvalidOperationException("No room in garage!");
            for (int i = 0; i < deliveryLocation.GarageSlots; i++)
            {
                if (deliveryLocation.garage[i] == null)
                {
                    deliveryLocation.garage[i] = vehicle;
                    for (int j = 0; j < GarageSlots; j++)
                    {
                        if (garage[j] != null)
                            if (garage[j].Equals(vehicle))
                            {
                                garage[j] = null;
                                break;
                            }
                    }
                    return i;
                }
            }
            return -1;
        }
        public int UnloadVehicle(int garageSlot)
        {
            var veicle = GetVehicle(garageSlot);
            if (IsFull) throw new InvalidOperationException("Storage is full!");


            int count = 0;
            for (int i = 0; i < veicle.Trunk.Count; i++)
            {
                //gurmi li?
                if (IsFull || veicle.IsEmpty) return count;
                if (count > products.Count() - 1) break;
                products[count] = veicle.Trunk.ToList()[count];
                count++;
            }
            return count;
        }
    }
}
