using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _551
{
    public sealed class Car : Vehicle
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fuel">fuel quantity</param>
        /// <param name="liters">liters per km</param>
        public Car(double fuel, double liters)
        {
            base.fuel = fuel;
            base.liters = liters;
        }

        // Override Interface Method
        public override void Drive(double distance)
        {
            var needed = distance * (base.liters + 0.9);
            if (needed <= base.fuel)
            {
                Helper.WriteLine($"Car travelled {distance} km");
                base.fuel -= needed;
            }
            else Helper.WriteLine("Car needs refueling");
        }

        // Override Interface Method
        public override void Refuel(double liters)
        {
            base.fuel += liters;
        }

    }
}
