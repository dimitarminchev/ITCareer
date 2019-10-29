using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Car
    {
        private int hp;
        private double fuelAmount;
        private Tyre tyre;

        public Tyre Tyre
        {
            get { return tyre; }
            set { tyre = value; }
        }

        public double FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }

        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }
    }
}
