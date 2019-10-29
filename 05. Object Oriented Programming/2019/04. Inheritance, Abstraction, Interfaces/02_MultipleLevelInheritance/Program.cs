using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MultipleLevelInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
        }
    }
}
