using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_AnimalFarm
{
    class Cat : Felime
    {
        public string breed { get; set; }
        public Cat(string animalType,string name,double weight,string livingRegion,string breed) :base(animalType,name, weight,livingRegion)
        {
            this.breed = breed;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }
        
        public override string ToString()
        {
            return $"{animalType}[{animalName},{breed},{animalWeight},{livingRegion}]";
        }
    }
}
