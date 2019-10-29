using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SingleInheritance
{
    // Derivative Class
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }
}
