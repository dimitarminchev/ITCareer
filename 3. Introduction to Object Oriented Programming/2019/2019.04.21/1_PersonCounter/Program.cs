using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PersonCounter
{
    class Program
    {
        static void Main(string[] args)
        {            
            // Програма демонстрираща статично поле и метод на клас
            Console.WriteLine("People = {0}", Person.Count());
            Person Ivan = new Person("Ivan", 12);            
            Console.WriteLine("People = {0}",Person.Count());
            Person Peter = new Person("Peter", 18);
            Console.WriteLine("People = {0}", Person.Count());
        }
    }
}
