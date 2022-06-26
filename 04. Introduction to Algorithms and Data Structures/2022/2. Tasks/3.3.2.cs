using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _332
{
    class Program
    {
        static void Main(string[] args)
        {
			// 3.3.2. Изчислете редицата с опашка
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);
            int poped = n;
            Queue<int> q = new Queue<int>();
            for (int i = 1; i < 50; i++)
            {
                int first = poped + 1;
                int second = poped * 2 + 1;
                int third = poped + 2;
                q.Enqueue(first);
                q.Enqueue(second);
                q.Enqueue(third);
                poped = q.Dequeue();
                Console.WriteLine(first);
                Console.WriteLine(second);
                Console.WriteLine(third);
            }
        }
    }
}
