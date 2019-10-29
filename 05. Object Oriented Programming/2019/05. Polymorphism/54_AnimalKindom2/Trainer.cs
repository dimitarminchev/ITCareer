using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_AnimalKindom2
{
    class Trainer
    {
        private IAnimal animal;

        public IAnimal Animal
        {
            get { return animal; }
            set { animal = value; }
        }
        public Trainer(IAnimal animal)
        {
            this.animal = animal;
        }

        public void Make()
        {
            animal.Perform();
        }
    }
}
