using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_AnimalFarm
{
    abstract class Felime :Mammal

    {
        public Felime(string animalType,string name, double weight, string livingRegion) : base(animalType,name, weight, livingRegion)
        {
        }
    }
}
