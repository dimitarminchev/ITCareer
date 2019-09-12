using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_AnimalFarm
{
    class Tiger : Felime
    {

        public Tiger(string animalType,string name, double weight, string livingRegion) : base(animalType,name, weight, livingRegion)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }
        public override string ToString()
        {
            return $"{animalType}[{animalName},{animalWeight},{livingRegion}]";
        }
    }
}
