using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57_AnimalFarm
{
    public abstract class Animal
    {
        public string animalName { get; }
        public string animalType { get; }
        public double animalWeight { get; }
        public int foodEaten { get; }

        public virtual void MakeSound()
        {
           
        }
        public void Eat()
        {
        }
        public Animal(string animalType,string name, double weight) 
        {
            this.animalType = animalType;
            this.animalName = name;
            this.animalWeight = weight;
        }
    }
}
