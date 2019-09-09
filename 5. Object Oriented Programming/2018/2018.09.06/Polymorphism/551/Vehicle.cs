using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _551
{
    public class Vehicle : IVehicle
    {
        // Fuel Quantity
        protected double fuel;
        public double Fuel
        {
            get
            {
                return this.fuel;
            }
        }

        // Liters per km
        protected double liters;
        public double Liters
        {
            get
            {
                return this.liters;
            }
        }

        // Implement Interface Method
        public virtual void Drive(double distance)
        {
            this.fuel -= distance * this.liters;
        }

        // Implement Interface Method
        public virtual void Refuel(double liters)
        {
            this.fuel += liters;
        }
    }
}
