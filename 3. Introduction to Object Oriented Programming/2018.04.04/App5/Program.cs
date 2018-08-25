using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Person First = new Person();
            Person Second = new Person(age);
            Person Third = new Person(name, age);

            Console.WriteLine("{0} {1}", First.Name, First.Age);
            Console.WriteLine("{0} {1}", Second.Name, Second.Age);
            Console.WriteLine("{0} {1}", Third.Name, Third.Age);

        }
    }
}
