using System;
using System.Linq;

namespace _712
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> knight = n => Console.WriteLine($"Sir {n}");
            string[] names = Console.ReadLine().Split().ToArray();
            foreach (var name in names) knight(name);
        }
    }
}
