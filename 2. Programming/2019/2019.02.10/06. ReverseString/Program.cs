using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReverseString
{
    class Program
    {
        // 6. Обръщане на масив от символни низове
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().ToArray();
            Console.WriteLine(string.Join(" ", array.Reverse()));
        }
    }
}
