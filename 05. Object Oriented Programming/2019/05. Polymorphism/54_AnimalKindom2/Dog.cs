using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_AnimalKindom2
{
    class Dog
    {
        public string MakeNoise()
        {
            return "Woof!";
        }

        public string MakeTrick()
        {
            return "Hold my paw, human!";
        }

        public void Perform()
        {
            MakeNoise();
            MakeTrick();
        }
    }
}
