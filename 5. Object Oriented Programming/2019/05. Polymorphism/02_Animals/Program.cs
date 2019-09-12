using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Animals
{
    class Program
    {
        // Task 2. Override Example
        static void Main(string[] args)
        {
            Animal cat = new Cat("Pesho", "Whiskas");
            Animal dog = new Dog("Gosho", "Meat");

            Console.WriteLine(cat.ExplainMyself());
            Console.WriteLine(dog.ExplainMyself());

        }
    }
}
