using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _471
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Маца", 12);
            Animal dog = new Dog("Шаро", 13);
            Console.WriteLine(cat.MakeNoise());
            Console.WriteLine(dog.MakeNoise());
        }
    }
    
}
