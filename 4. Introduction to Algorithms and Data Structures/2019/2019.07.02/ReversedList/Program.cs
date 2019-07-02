using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedList
{
    class Program
    {
        // ReversedList = Обратен списък
        static void Main(string[] args)
        {
            // Create
            var list = new ReversedList<int>();

            // Count = 0, Capacity = 2
            Console.WriteLine("Count = {0}, Capacity = {1}", list.Count, list.Capacity); 

            // Add
            list.Add(112);
            list.Add(911);
            list.Add(166);
            list.Add(160);
            list.Add(150);

            // Print
            Console.WriteLine(string.Join(" ", list));

            // Count = 5, Capacity = 8
            Console.WriteLine("Count = {0}, Capacity = {1}", list.Count, list.Capacity);
        }
    }
}
