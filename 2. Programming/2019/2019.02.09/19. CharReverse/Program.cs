using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.CharReverse
{
    class Program
    {
        // 19. Обръщане на знаци
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            object reversed =  $"{c}{b}{a}";
            Console.WriteLine(reversed);
        }
    }
}
