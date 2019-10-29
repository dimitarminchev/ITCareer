using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class Program
    {
        // DoublyLinkedList = Двусвързан спиък
        static void Main(string[] args)
        {
            // Create
            var list = new DoublyLinkedList<int>();

            // Add
            list.AddFirst(112);
            list.AddFirst(911);
            list.AddFirst(166);
            list.AddFirst(160);
            list.AddFirst(150);

            // Print
            Console.WriteLine(string.Join(" ", list));
            Console.WriteLine("Count = {0}", list.Count);
        }
    }
}
