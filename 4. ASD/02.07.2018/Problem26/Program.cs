using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem26
{
    class Program
    {
        /* Problem 26. DoublyLinkedList */
        static void Main(string[] args)
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();

            // Input
            list.AddFirst(10);
            list.AddFirst(23);
            list.AddFirst(14);

            // Remove First
            //Console.WriteLine(list.RemoveFirst());

            // Remove Last
            //Console.WriteLine(list.RemoveLast());

            // Print
            Console.WriteLine(string.Join(", ",list.ToArray()));

        }
    }
}
