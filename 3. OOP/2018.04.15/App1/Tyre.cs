using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Tyre
    {
        private string name;
        private double hardness;
        private double degradation;
        private double grip;
        public Tyre(string name, double hardness, double grip = 0)
        {
            this.name = name;
            this.hardness = hardness;
            this.degradation = 100;
            this.grip = grip;
        }
        public double Degradation
        {
            get { return degradation; }
            set { degradation = value; }
        }
        public double Hardness
        {
            get { return hardness; }
            set { hardness = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Grip
        {
            get { return grip; }
            set { grip = value; }
        }

    }
}
