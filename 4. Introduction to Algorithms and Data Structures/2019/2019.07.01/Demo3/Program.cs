using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Циркулярна опашка (FIFO or LILO)
            var queue = new CircularQueue<int>(); 

            // Добавяме
            var items = Console.ReadLine().Split().Select(int.Parse).ToArray();
            foreach (var item in items)
            {
                queue.Enqueue(item);
            }

            // Печат
            while(queue.Count > 0)
            {
                Console.Write("{0} ",queue.Dequeue());
            }
        }
    }
}
