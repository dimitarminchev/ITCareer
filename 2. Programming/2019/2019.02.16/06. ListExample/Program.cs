using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Въвеждане на списък от конзолата
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            // Отпечатване на списък в конзолата
            Console.WriteLine(string.Join(", ", list));            
        }
    }
}
