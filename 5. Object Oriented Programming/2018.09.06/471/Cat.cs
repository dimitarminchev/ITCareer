using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _471
{
    public class Cat : Animal
    {
        public Cat(string Name,int Age):base(Name,Age) {}

        public override string MakeNoise()
        {
            return $"Meow!";
        }

        public override string MakeTrick()
        {
            return $"No trick for you! I'm too lazy!";
        }
    }
}
