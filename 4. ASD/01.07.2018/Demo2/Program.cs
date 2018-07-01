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
            Console.WriteLine("Count = {0}", list.Count);

            // Search
            Console.WriteLine("Index = {0}", list.IndexOf(42)); // -1
            list.Add(42);
            Console.WriteLine("Index = {0}", list.IndexOf(42)); // 1
            list.Add(23);
            Console.WriteLine("Index = {0}", list.IndexOf(66)); // -1

            //list.Add(42);
            //list.Add(23);
            //list.Add(61);
            //Console.WriteLine("Count = {0}", list.Count);



        }
    }
}
