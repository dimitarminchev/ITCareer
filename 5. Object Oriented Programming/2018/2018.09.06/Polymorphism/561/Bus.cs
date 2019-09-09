using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _561
{
    class Bus : Vehicle
    {
        private const double AC = 1.4;
        public Bus(double fuel, double consumption, double fuelCapacity) : base(fuel, consumption, fuelCapacity)
        {
        }

        public override void Drive(double distance, bool isAcOn)
        {
            double requiredFuel = 0;
            if (isAcOn)
                requiredFuel = distance * (this.Consumption + Bus.AC);
            else
                requiredFuel = distance * this.Consumption;

            if (requiredFuel <= this.Fuel)
            {
                this.Fuel -= requiredFuel;
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
            else Console.WriteLine($"{this.GetType().Name} needs refueling.");

        }

        public override double Fuel
        {
            set
            {
                if (value >= base.FuelCapacity)
                {
                    Console.WriteLine("Cannot fit fuel in tank");
                }
                else base.fuel = value;
            }
        }
    }
}
