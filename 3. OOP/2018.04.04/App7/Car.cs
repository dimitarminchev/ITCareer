using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App7
{
    class Car
    {
        // Name
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Fuel
        private float fuel;
        public float Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }

        // perkm
        private float perkm;
        public float Perkm
        {
            get { return perkm; }
            set { perkm = value; }
        }

        // The Magic
        public void TheMagic(float km)
        {
            if (km * this.perkm > this.fuel) Console.WriteLine("Insufficient fuel for the drive");
            else
            {
                this.fuel -= (km * this.perkm);
                Console.WriteLine("{0} {1:f2} {2}", this.name, this.fuel, km);
            }

        }
    }
}
