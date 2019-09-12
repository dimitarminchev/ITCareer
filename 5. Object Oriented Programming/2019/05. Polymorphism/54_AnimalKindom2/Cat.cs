using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_AnimalKindom2
{
    class Cat : IAnimal
    {
        public string MakeNoise()
        {
            return "Meow!";
        }

        public string MakeTrick()
        {
            return "No trick for you! I'm too lazy!";
        }

        public void Perform()
        {
            MakeNoise();
            MakeTrick();
        }
    }
}
