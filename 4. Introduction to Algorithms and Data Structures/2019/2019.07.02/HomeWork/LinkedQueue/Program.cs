using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //FIFO / LILO
            LinkedQueue<int> q = new LinkedQueue<int>();

            q.Enqueue(13);
            q.Enqueue(42);
            q.Enqueue(17);

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}
