using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Driver
    {
        private string type;
        private string name;
        private double totalTime;
        private Car car;
        private double fuelConsumptionPerKm;
        private double speed;
        private double speedMultiplier;

        public Driver(string type, string name, int hp, double fuelAmount, string tyreType, double tyreHardness, double grip = 0)
        {
            if ((type != "Aggressive" && type != "Endurance") || fuelAmount < 0 ||
                (tyreType != "Ultrasoft" && tyreType != "Hard"))
                throw new ArgumentException("Invalid data.");
            this.type = type;
            this.name = name;
            this.car = new Car()
            {
                HP = hp,
                FuelAmount = fuelAmount,
                Tyre = new Tyre
                (
                    tyreType, tyreHardness, grip
                )

            };
            if (type == "Aggressive")
            {
                fuelConsumptionPerKm = 2.7;
                speedMultiplier = 1.3;
            }
            else
            {
                fuelConsumptionPerKm = 1.5;
                speedMultiplier = 1;
            }
            this.speed = (hp + 100) / fuelAmount * speedMultiplier;
        }
        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public double FuelConsumptionPerKm
        {
            get { return fuelConsumptionPerKm; }
            set { fuelConsumptionPerKm = value; }
        }

        public Car Car
        {
            get { return car; }
            set { car = value; }
        }

        public double TotalTime
        {
            get { return totalTime; }
            set { totalTime = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
