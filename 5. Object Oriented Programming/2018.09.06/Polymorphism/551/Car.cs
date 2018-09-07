using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _551
{
    public class Car : Vehicle
    {
        public Car(double fuel_quantity, double liters_per_km)
        {
            base.fuel_quantity = fuel_quantity;
            base.liters_per_km = liters_per_km;
        }

        public override void Drive(double distance)
        {
            var fuel_needed = distance * (base.liters_per_km + 0.9);
            if (fuel_needed <= base.fuel_quantity)
            {
                Helper.WriteLine($"Car travelled {distance} km");
                base.fuel_quantity -= fuel_needed;
            }
            else Helper.WriteLine("Car needs refueling");
        }

        public override void Refuel(double liters)
        {
            base.fuel_quantity += liters;
        }


    }
}
