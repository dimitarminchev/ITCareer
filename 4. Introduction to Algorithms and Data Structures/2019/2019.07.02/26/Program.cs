using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26
{
    class Program
    {
        // 26. DoublyLinkedList
        static void Main(string[] args)
        {
            // FILO or LIFO
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();

            Console.WriteLine("Count = {0}", list.Count);       // 0
 
            list.AddFirst(112);
            list.AddFirst(911);
            list.AddFirst(166);
            list.AddFirst(160);
            list.AddFirst(150);

            foreach (var item in list)
                Console.Write("{0} ", item);
            Console.WriteLine();

            Console.WriteLine("Count = {0}", list.Count);       // 5
        }
    }
}
