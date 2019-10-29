using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_Vehicles2
{
    class Truck:IVehicle
    {
        private double fuel, litersperkm, distance,fuelCapacity;
        public double Fuel { get { return fuel; } }
        public double Litersperkm { get { return litersperkm; } }
        public double Distance { get { return distance; } }

        public double FuelCapacity { get { return fuelCapacity; } }

        public void Drive(double km)
        {
            double travel = litersperkm * km;
            if (travel <= fuel)
            {
                fuel -= travel;
                Console.WriteLine($"Truck travelled {km} km");
                distance += km;
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public void Refuel(double litres)
        {
            if (litres < 0 || litres > fuelCapacity)
                Console.WriteLine("Cannot fit fuel in tank");
            else this.fuel += litres;

        }
        public Truck(double fuel, double l, double fuelCapacity)
        {
            this.fuel = fuel*0.95;
            this.fuelCapacity = fuelCapacity;
            this.litersperkm = l + 1.6;
        }
    }
}
