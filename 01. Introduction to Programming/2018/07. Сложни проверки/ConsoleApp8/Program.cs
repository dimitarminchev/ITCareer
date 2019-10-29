using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8. Клас животно
            var name = Console.ReadLine().ToLower();
            switch(name)
            {
                case "dog": { Console.WriteLine("mammal"); break; }
                case "crocodile":
                case "tortoise":
                case "snake": { Console.WriteLine("reptile"); break; }
                default: { Console.WriteLine("unknown"); break; }
            }
        }
    }
}
