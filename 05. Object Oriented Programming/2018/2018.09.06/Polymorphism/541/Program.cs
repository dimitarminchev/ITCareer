using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _541
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dog
            Trainer dog = new Trainer(new Dog());
            dog.Make();

            // Cat
            Trainer cat = new Trainer(new Cat());
            cat.Make();
        }
    }
}
