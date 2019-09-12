using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_Vehicles2
{
    class Car : IVehicle
    {
        private double fuel, litersperkm, distance, fuelCapacity;
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
                Console.WriteLine($"Car travelled {km} km");
                distance += km;
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }

        public void Refuel(double litres)
        {
            if (litres < 0 || litres > fuelCapacity)
               Console.WriteLine("Cannot fit fuel in tank");
            else  this.fuel += litres;

        }
        public Car(double fuel,double l,double cap)
        {
            this.fuel = fuel;
            this.litersperkm = l+0.9;
            this.fuelCapacity = cap;
        }
    }
}
