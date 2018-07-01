using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Program
    {
        /* Свързан списък */
        static void Main(string[] args)
        {
            DinamicList list = new DinamicList();
            // Console.WriteLine("Count = {0}", list.Count);

            list.Add(42); // 0
            list.Add(23); // 1
            list.Add(61); // 2
            Console.WriteLine("Count = {0}", list.Count);

            Console.WriteLine("Removed = {0}", list.Remove(0));
            Console.WriteLine("Count = {0}", list.Count);

            Console.WriteLine("Removed = {0}", list.Remove(1));
            Console.WriteLine("Count = {0}", list.Count);

            Console.WriteLine("Removed = {0}", list.Remove(0));
            Console.WriteLine("Count = {0}", list.Count);

            Console.WriteLine("Removed = {0}", list.Remove(0));
            Console.WriteLine("Count = {0}", list.Count);

        }
    }
}
