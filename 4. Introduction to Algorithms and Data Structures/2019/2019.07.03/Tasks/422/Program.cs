using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _422
{
    class Program
    {
        // Автор: Веселин Инзов
        // 5 4 3 2 1
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Sort.Insertion(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
