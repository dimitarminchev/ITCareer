using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _561
{
    class Car : Vehicle
    {
        private const double ConsumptionModifier = 0.9;
        public Car(double fuel, double consumption, double fuelCapacity) : base(fuel , consumption + ConsumptionModifier, fuelCapacity) {}
        public override double Fuel
        {
            set
            {
                if(value >= base.FuelCapacity)
                {
                    Console.WriteLine("Cannot fit fuel in tank");
                }
                else base.fuel = value;
            }
        }
    }
}
