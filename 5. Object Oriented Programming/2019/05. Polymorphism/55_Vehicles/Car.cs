using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55_Vehicles
{
    class Car : IVehicle
    {
        private double fuel, litersperkm, distance;
        public double Fuel { get { return fuel; } }
        public double Litersperkm { get { return litersperkm; } }
        public double Distance { get { return distance; }  }

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
            this.fuel += litres;
        }
        public Car(double fuel,double l)
        {
            this.fuel = fuel;
            this.litersperkm = l+0.9;
        }
    }
}
