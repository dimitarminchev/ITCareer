using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Намиране на по-голямото число
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
    }
}
