using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _551
{
    // Vehicle Interface
    public interface IVehicle
    {
        void Drive(double distance);
        void Refuel(double liters);
    }
}
