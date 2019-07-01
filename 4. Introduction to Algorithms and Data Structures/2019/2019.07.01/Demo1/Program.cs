using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Разтеглив масив
            var list = new ArrayList<int>();

            // Добавяне на елемент
            list.Add(42); // Cap = 2, Count = 1
            list.Add(13); // Cap = 2, Count = 2
            list.Add(17); // Cap = 4, Count = 3

            Console.WriteLine(list.RemoveAt(2)); // Cap = 2, Count = 2
            Console.WriteLine(list.RemoveAt(1)); // Cap = 2, Count = 1
            Console.WriteLine(list.RemoveAt(0)); // Cap = 2, Count = 0
        }
    }
}
