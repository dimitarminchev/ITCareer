using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem25
{
    class Program
    {
        /* Problem 25. ReversedList */
        static void Main(string[] args)
        {
            ReversedList<int> list = new ReversedList<int>();

            Console.WriteLine("Count = {0}", list.Count);
            Console.WriteLine("Capacity = {0}", list.Capacity);

            list.Add(7);
            list.Add(5);
            list.Add(12);

            Console.WriteLine("Count = {0}", list.Count);
            Console.WriteLine("Capacity = {0}", list.Capacity);

        }
    }
}
