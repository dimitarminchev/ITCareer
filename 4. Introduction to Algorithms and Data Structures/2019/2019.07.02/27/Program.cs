using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27
{
    class Program
    {
        // 27. LinkedQueue
        static void Main(string[] args)
        {
            // FIFO or LILO
            LinkedQueue<int> queue = new LinkedQueue<int>();

            Console.WriteLine("Count = {0}", queue.Count); // 0

            queue.Enqueue(112);
            queue.Enqueue(911);
            queue.Enqueue(166);
            queue.Enqueue(160);
            queue.Enqueue(150);

            foreach (var item in queue)
                Console.Write("{0} ", item);
            Console.WriteLine();

            Console.WriteLine("Count = {0}", queue.Count); // 5
        }
    }
}
