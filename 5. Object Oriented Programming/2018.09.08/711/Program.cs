using System;
using System.Linq;

namespace _711
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printer = n => Console.WriteLine(n);
            string[] names = Console.ReadLine().Split().ToArray();
            foreach (var name in names) printer(name);
        }
    }
}
