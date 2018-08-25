using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem23
{
    class Program
    {
        /* Problem 23. CircularQueue */
        static void Main(string[] args)
        {
            // Създаване на циркулярна опашка
            CircularQueue<int> q = new CircularQueue<int>();

            // Добаване на елементи
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            // Информация
            Console.WriteLine("Count = {0}",q.Count);
            Console.WriteLine("Remove = {0}", q.Dequeue());
            Console.WriteLine("Count = {0}", q.Count);
        }
    }
}
