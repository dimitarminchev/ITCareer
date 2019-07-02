using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedQueue
{
    class Program
    {
        // LinkedQueue = Свързана опашка
        static void Main(string[] args)
        {
            // Create
            var queue = new LinkedQueue<int>();

            // Input
            queue.Enqueue(112);
            queue.Enqueue(911);
            queue.Enqueue(166);
            queue.Enqueue(160);
            queue.Enqueue(150);

            // Print
            Console.WriteLine(string.Join(" ", queue));
            Console.WriteLine("Count = {0}", queue.Count);
        }
    }
}
