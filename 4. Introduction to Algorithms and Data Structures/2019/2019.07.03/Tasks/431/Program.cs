using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _431
{
    class Program
    {
        // Автор: Ганчо Първанов
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Sort.Merge(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
