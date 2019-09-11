using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }

        public override void MakeNoise()
        {
            Console.WriteLine("Woof!");
            base.MakeNoise();
        }

        public override void MakeTrick()
        {
            Console.WriteLine("Hold my paw, human!");
        }
    }
}
