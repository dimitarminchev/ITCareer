using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorageMaster.Entities.Vehicles;

namespace StorageMaster.Storage
{
    class Warehouse : Storage
    {
        public Warehouse(string name) : base(name, 10, 10, new List<Vehicle> { new Semi(), new Semi(), new Semi() })
        {

        }
    }
}
