using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem22
{
    class Program
    {
        /* Problem 22. CustomArrayList */
        static void Main(string[] args)
        {
            CustomArrayList list = new CustomArrayList();

            Console.WriteLine("Count = {0}", list.Count);
            Console.WriteLine("Capacity = {0}", list.Capacity);

            list.Add(100); // 0
            list.Add(200); // 1
            list.Add(300); // 2

            list.Clear(); // zero

            list.Add(400); // 0 
            list.Add(500); // 1

            list.Insert(0, 69696969);

            Console.WriteLine("Count = {0}", list.Count);
            Console.WriteLine("Capacity = {0}", list.Capacity);
        }
    }
}
