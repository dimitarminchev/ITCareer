using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageMaster.Products;
using StorageMaster.Entities.Vehicles;

namespace StorageMaster.Storage
{
    public class StorageMaster
    {
        public  List<Product> products = new List<Product>();
        public  List<Storage> storages = new List<Storage>();
        private  int currentVehiclePos = -1;
        private  int storagePos = -1;
        public  string AddProduct(string type, double price)
        {
            switch (type)
            {
                case "Gpu": products.Add(new Gpu(price)); break;
                case "HardDrive": products.Add(new HardDrive(price)); break;
                case "Ram": products.Add(new Ram(price)); break;
                case "SolidStateDrive": products.Add(new SolidStateDrive(price)); break;
                default: throw new InvalidOperationException("Invalid product type!");
            }
            return $"Added {type} to pool";
        }



        public  string RegisterStorage(string type, string name)
        {
            switch (type)
            {
                case "AutomatedWarehouse": storages.Add(new AutomatedWarehouse(name)); break;
                case "DistributionCenter": storages.Add(new DistributionCenter(name)); break;
                case "Warehouse": storages.Add(new Warehouse(name)); break;
                default: throw new InvalidOperationException("Invalid storage type!");
            }
            return $"Registered {name}";
        }


        public  string SelectVehicle(string storageName, int garageSlot)
        {
            var storage = storages.First(x => x.Name == storageName);
            var vehicle = storage.GetVehicle(garageSlot);
            currentVehiclePos = storage.Garage.ToList().IndexOf(vehicle);
            storagePos = storages.IndexOf(storage);
            string type = string.Empty;
            if (vehicle is Van) type = "Van";
            else if (vehicle is Truck) type = "Truck";
            else type = "Semi";

            return $"Selected {type}";
        }


        public  string LoadVehicle(IEnumerable<string> productNames)
        {
            var vehicle = storages[storagePos].Garage.ToList()[currentVehiclePos];
            string vehicleType = vehicle.GetType().Name;
            int loadedProductsCount = 0;
            foreach (var item in productNames)
            {
                Product last;
                switch (item)
                {
                    case "Gpu": if (products.Count(x => x is Gpu) == 0) throw new InvalidOperationException($"{item} is out of stock!"); last = products.Last(x => x is Gpu); break;
                    case "HardDrive": if (products.Count(x => x is HardDrive) == 0) throw new InvalidOperationException($"{item} is out of stock!"); last = products.Last(x => x is HardDrive); break;
                    case "Ram": if (products.Count(x => x is Ram) == 0) throw new InvalidOperationException($"{item} is out of stock!"); last = products.Last(x => x is Ram); break;
                    case "SolidStateDrive": if (products.Count(x => x is SolidStateDrive) == 0) throw new InvalidOperationException($"{item} is out of stock!"); last = products.Last(x => x is SolidStateDrive); break;
                    default: throw new InvalidOperationException($"{item} is out of stock!");
                }
                if (last == null) throw new InvalidOperationException($"{item} is out of stock!");
                if (vehicle.IsFull) break;
                vehicle.LoadProduct(last);
                products.Remove(last);
                loadedProductsCount++;
            }
            return $"Loaded {loadedProductsCount}/{productNames.Count()} products into {vehicleType}";
        }

        public  string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            if (storages.Count(x => x.Name == sourceName) <= 0) throw new InvalidOperationException("Invalid source storage!");
            if (storages.Count(x => x.Name == destinationName) <= 0) throw new InvalidOperationException("Invalid destination storage!");
            var vehicle = storages.First(x => x.Name == sourceName).Garage.ToList()[sourceGarageSlot];
            if(vehicle == null) throw new InvalidOperationException("No vehicle in this garage slot!");
            string vehicleType = vehicle.GetType().Name;
            int destinationGarageSlot = storages.First(x => x.Name == sourceName).SendVehicleTo(sourceGarageSlot, storages.First(x => x.Name == destinationName));
            return $"Sent {vehicleType} to {destinationName} (slot {destinationGarageSlot})";
        }

        public  string UnloadVehicle(string storageName, int garageSlot)
        {
            var storage = storages.First(x => x.Name == storageName);
            var vehicle = storage.GetVehicle(garageSlot);
            int productsInVehicle = vehicle.Trunk.Count();
            int unloadedProductsCount = storage.UnloadVehicle(garageSlot);
            return $"Unloaded {unloadedProductsCount}/{productsInVehicle} products at {storageName}";
        }

        public  string GetStorageStatus(string storageName)
        {
            var storage = storages.First(x => x.Name == storageName);
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (var item in storage.Products)
            {
                if (item == null) continue;
                switch (item.GetType().Name)
                {
                    case "Gpu": if (!dic.ContainsKey("Gpu")) dic.Add("Gpu", 0); dic["Gpu"]++; break;
                    case "HardDrive": if (!dic.ContainsKey("HardDrive")) dic.Add("HardDrive", 0); dic["HardDrive"]++; break;
                    case "Ram": if (!dic.ContainsKey("Ram")) dic.Add("Gpu", 0); dic["Ram"]++; break;
                    case "SolidStateDrive": if (!dic.ContainsKey("SolidStateDrive")) dic.Add("SolidStateDrive", 0); dic["SolidStateDrive"]++; break;
                }
            }
            dic = dic.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            string stock = string.Format("Stock({0}/{1}): [", storage.Products.Where(x => x != null).Select(x => x.Weight).Sum(),
                storage.Capacity); if (storage.Products.Where(x => x != null).Count() != 0) foreach (var item in dic)
                {
                    if (item.Equals(dic.Last()))
                        stock += $"{item.Key} ({item.Value})";
                    else
                    stock += $"{item.Key} ({item.Value}), ";
                }
            stock += "]" + Environment.NewLine;
            List<Vehicle> a = new List<Vehicle>();
            foreach (var item in storage.Garage)
            {
                if (item != null) a.Add(item);
            }
            string garage = "Garage: [";
            var gar = storage.Garage;
            for (int i = 0; i < gar.Count; i++)
            {
                if (gar.ToList()[i] != null) garage += gar.ToList()[i].GetType().Name;
                else garage += "empty";
                if (i != gar.Count - 1) garage += "|";
            }
            garage += "]";
            return stock + garage;
        }

        public  string GetSummary()
        {
            var sorted = storages.Where(x => x.Products.Count(y => y != null) != 0).OrderBy(x => x.Products.Where(y=>y!=null).Select(y => y.Price).Sum()).ToList();

            StringBuilder sb = new StringBuilder();
            foreach (var item in sorted)
            {
                double a = item.Products.Where(x=>x!=null).Select(y => y.Price).Sum();
                sb.AppendLine(string.Format("{0}:{1}Storage worth: ${2:F2}", item.Name, Environment.NewLine, a));
            }
            foreach (var item in storages)
            {
                if (!sorted.Contains(item)) sb.AppendLine($"{item.Name}:{Environment.NewLine}Storage worth: $0.00");
            }
            return sb.ToString();
        }
    }
}

