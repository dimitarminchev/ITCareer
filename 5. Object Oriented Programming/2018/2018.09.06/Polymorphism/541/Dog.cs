using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _541
{
    public class Dog : IAnimal
    {
        public string MakeNoise()
        {
            // Console.WriteLine("Woof!");
            return "Woof!";
        }

        public string MakeTrick()
        {
            // Console.WriteLine("Hold my paw, human!");
            return "Hold my paw, human!";
        }

        public void Perform()
        {
            Console.WriteLine(MakeNoise());
            Console.WriteLine(MakeTrick());
        }
    }
}
