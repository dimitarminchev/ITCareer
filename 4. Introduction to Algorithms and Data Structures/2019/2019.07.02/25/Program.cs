using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25
{
    class Program
    {
        // 25. ReversedList
        static void Main(string[] args)
        {
            // FILO or LIFO
            ReversedList<int> list = new ReversedList<int>();

            Console.WriteLine("Count = {0}", list.Count);       // 0
            Console.WriteLine("Capacity = {0}", list.Capacity); // 2

            list.Add(112);
            list.Add(911);
            list.Add(166);
            list.Add(160);
            list.Add(150);

            foreach (var item in list)
                Console.Write("{0} ", item);
            Console.WriteLine();

            Console.WriteLine("Count = {0}", list.Count);       // 5
            Console.WriteLine("Capacity = {0}", list.Capacity); // 8
        }
    }
}
