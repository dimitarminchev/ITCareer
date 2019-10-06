using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageMaster.Entities.Vehicles;

namespace StorageMaster.Storage
{
    class AutomatedWarehouse : Storage
    {
        public AutomatedWarehouse(string name) : base(name, 1, 2, new List<Vehicle> { new Truck() })
        {

        }
    }
}
