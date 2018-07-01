using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    class Program
    {
        /* Опашка и стек */
        static void Main(string[] args)
        {
            // FIFO = LILO            
            Queue<int> q = new Queue<int>();
            
            q.Enqueue(112); // 1
            q.Enqueue(911); // 2
            q.Enqueue(166); // 3

            // Print
            Console.WriteLine("Queue");
            while (q.Count > 0)
            {
                int item = q.Dequeue();
                Console.WriteLine(item);
            }

            // FILO = LIFO
            Stack<int> s = new Stack<int>();
            s.Push(112); // 1
            s.Push(911); // 2
            s.Push(166); // 3

            // Print
            Console.WriteLine("Stack");
            while (s.Count > 0)
            {
                int item = s.Pop();
                Console.WriteLine(item);
            }
        }
    }
}
