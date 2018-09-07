using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _551
{
    public abstract class Vehicle
    {
        public double fuel_quantity;
        public double liters_per_km;

        public abstract void Drive(double distance);
        public abstract void Refuel(double liters);
    }
}
