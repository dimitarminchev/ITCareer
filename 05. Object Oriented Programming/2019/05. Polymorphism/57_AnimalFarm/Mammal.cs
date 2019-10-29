using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_AnimalFarm
{
    abstract class Mammal: Animal
    {
        public string livingRegion { get; }
        public Mammal(string animalType,string name, double weight, string livingRegion) : base(animalType,name, weight)
        {
            this.livingRegion = livingRegion;
        }
    }
}
