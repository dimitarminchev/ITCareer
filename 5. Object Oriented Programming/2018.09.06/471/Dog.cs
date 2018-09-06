using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _471
{
    class Dog : Animal
    {
        public Dog(string Name,int Age):base(Name,Age) {}
        public override string MakeNoise()
        {
            return $"Woof!";
        }

        public override string MakeTrick()
        {
            return $"Hold my paw, human!";
        }
    }
}
