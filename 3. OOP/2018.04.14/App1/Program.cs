using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Ivan = new Person("Ivan", 23);
            Console.WriteLine(Person.Counter);

            Person Peter = new Person("Peter", 42);
            Console.WriteLine(Person.Counter);
        }
    }
}
