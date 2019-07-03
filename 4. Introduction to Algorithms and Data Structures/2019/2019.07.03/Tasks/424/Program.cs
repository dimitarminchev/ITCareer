using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _424
{
    class Program
    {
/*
10
4 2 6 3 8 1 7 4 2 9
*/
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var left = arr.Take(arr.Length/2).OrderBy(x => x).ToArray();
            var right = arr.Skip(arr.Length / 2).Take(arr.Length-arr.Length/2).OrderByDescending(x => x).ToArray();
            Console.WriteLine(string.Join(" ",left.Concat(right).ToArray()));
        }
    }
}
