using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _541
{
    public class Cat : IAnimal
    {
        public string MakeNoise()
        {
            // Console.WriteLine("Meow!");
            return "Meow!";
        }

        public string MakeTrick()
        {
            // Console.WriteLine("No trick for you! I'm too lazy!");
            return "No trick for you! I'm too lazy!";
        }

        public void Perform()
        {
            Console.WriteLine(MakeNoise());
            Console.WriteLine(MakeTrick());
        }
    }
}
