using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public string Model { get; private set; }
        public string Color { get; private set; }
        public int Batteries { get; private set; }
        public Tesla(string model, string color, int batteries)
        {
            this.Model = model;
            this.Color = color;
            this.Batteries = batteries;
        }
        public string Start()
        {
            return "Engine start";
        }
        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return string.Format("{0} Tesla {1} with {2} Batteries\n{3}\n{4}",
                   this.Color, this.Model, this.Batteries, this.Start(), this.Stop());
        }
    }

}
