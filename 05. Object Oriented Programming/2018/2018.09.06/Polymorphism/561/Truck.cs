using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _561
{
    class Truck : Vehicle
    {
        private const double ConsumptionModifier = 1.6;
        private const double RefuelingLoss = 0.95;
        public Truck(double fuel, double consumption, double fuelCapacity) : base(fuel, consumption + ConsumptionModifier, fuelCapacity) {}

        public override void Refuel(double fuel)
        {
            base.Refuel(RefuelingLoss*fuel);
        }
    }
}
