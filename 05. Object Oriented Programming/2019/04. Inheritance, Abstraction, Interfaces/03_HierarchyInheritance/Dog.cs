using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_HierarchyInheritance
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
