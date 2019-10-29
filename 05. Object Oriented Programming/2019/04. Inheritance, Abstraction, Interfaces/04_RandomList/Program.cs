using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_RandomList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create RandomList
            RandomList list = new RandomList();

            // Add some data to the RandomList
            list.Add(42);
            list.Add("fourty two");
            list.Add(3.14);

            // Print the RandomList
            Console.WriteLine("Print: {0}",string.Join(", ", list.ToArray()));

            // Remove some data from the RandomList
            Console.WriteLine("Remove: {0}", list.RandomObject());
            Console.WriteLine("Remove: {0}", list.RandomObject());
            Console.WriteLine("Remove: {0}", list.RandomObject());
        }
    }
}
