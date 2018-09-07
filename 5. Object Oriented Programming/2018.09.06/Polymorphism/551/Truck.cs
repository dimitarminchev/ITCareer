using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _551
{
    public class Truck : Vehicle
    {
        public Truck(double fuel_quantity, double liters_per_km)
        {
            base.fuel_quantity = fuel_quantity;
            base.liters_per_km = liters_per_km;
        }

        public override void Drive(double distance)
        {
            var fuel_needed = distance * (base.liters_per_km + 1.6);
            if (fuel_needed <= base.fuel_quantity)
            {
                Helper.WriteLine($"Truck travelled {distance} km");
                base.fuel_quantity -= fuel_needed;
            }
            else Helper.WriteLine("Truck needs refueling");
        }

        public override void Refuel(double liters)
        {
            base.fuel_quantity += (liters * 0.95);
        }
    }
}
