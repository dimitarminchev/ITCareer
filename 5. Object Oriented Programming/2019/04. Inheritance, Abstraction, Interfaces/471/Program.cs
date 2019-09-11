using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog doge = new Dog("vanko", 2);

            doge.MakeNoise();
            doge.MakeTrick();
        }
    }
}