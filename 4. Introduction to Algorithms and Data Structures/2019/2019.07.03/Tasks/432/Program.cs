using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _432
{
    class Program
    {
        // Автор: Ганчо Първанов
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Sort.Quick(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
