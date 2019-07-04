using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _511
{
    class Program
    {
        // Автор: Ганчо Първанов
        static void Main(string[] args)
        {
            int index = 0;
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = int.Parse(Console.ReadLine());
            index = Search.Linear(numbers, n);
            if(index == -1)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }
}
