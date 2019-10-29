using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55_Vehicles
{
    class Truck:IVehicle
    {
        private double fuel, litersperkm, distance;
        public double Fuel { get { return fuel; } }
        public double Litersperkm { get { return litersperkm; } }
        public double Distance { get { return distance; } }

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
            this.fuel += litres;
        }
        public Truck(double fuel, double l)
        {
            this.fuel = fuel*0.95;
            this.litersperkm = l + 1.6;
        }
    }
}
