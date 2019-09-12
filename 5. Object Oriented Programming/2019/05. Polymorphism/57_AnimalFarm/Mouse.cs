using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_AnimalFarm
{
    class Mouse : Mammal
    {
        public Mouse(string animalType,string name, double weight, string livingRegion) : base(animalType,name, weight, livingRegion)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine("SQUEEEAAAK!");
        }
        public override string ToString()
        {
            return $"{animalType}[{animalName},{animalWeight},{livingRegion}]";
        }
    }
}
