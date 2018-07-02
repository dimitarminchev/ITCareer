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

            Console.WriteLine("Count = {0}", list.Count);       // 0
            Console.WriteLine("Capacity = {0}", list.Capacity); // 2

            list.Add(7);
            list.Add(5);
            list.Add(12);

            foreach (var item in list) Console.WriteLine(item);

            Console.WriteLine("Count = {0}", list.Count);       // 3
            Console.WriteLine("Capacity = {0}", list.Capacity); // 4

            Console.WriteLine("Remove {0}", list.RemoveAt(1));  // 7

            Console.WriteLine("Count = {0}", list.Count);       // 2
            Console.WriteLine("Capacity = {0}", list.Capacity); // 4 

        }
    }
}
