using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3.ThreadsDemo
{
    class Program
    {
        static void PrintNumbersFrom1To100()
        {
            for (int i = 1; i <= 100; i++)
            Console.WriteLine
            (
                "Thread Id #{0}, Number #{1}",
                Thread.CurrentThread.ManagedThreadId.ToString(),
                i
            );
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread t = new Thread
                (
                    new ThreadStart(PrintNumbersFrom1To100)
                );
                t.Start();                
            }
        } // The End of the Main Thread
    }
}
