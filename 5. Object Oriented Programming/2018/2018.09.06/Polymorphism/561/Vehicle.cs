using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _561
{
    abstract class Vehicle
    {
        protected double fuel;
        private double consumption;
        private double fuelCapacity;

        public double FuelCapacity
        {
            get{ return fuelCapacity; }
            set { fuelCapacity = value; }
        }

        public double Consumption
        {
            get { return consumption; }
            set { consumption = value; }
        }

        public virtual double Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }
        public Vehicle(double fuel, double consumption, double fuelCapacity)
        {
            this.Consumption = consumption;
            this.FuelCapacity = fuelCapacity;
            this.Fuel = fuel;
        }
        public virtual void Drive(double distance, bool isAcOn = true)
        {
            if (distance * consumption > fuel)
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling.");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
                fuel -= distance * consumption;
            }
        }

        public virtual void Refuel(double fuelQ)
        {
            if(this.Fuel + fuelQ <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else this.Fuel += fuelQ;
        }
    }
}
