using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Chicken chicken = new Chicken(name, age);
            Console.WriteLine( "Chicken {0} (age {1}) can produce {2} eggs per day.", 
                                chicken.Name, chicken.Age, chicken.ProductPerDay);
        }
    }
}
