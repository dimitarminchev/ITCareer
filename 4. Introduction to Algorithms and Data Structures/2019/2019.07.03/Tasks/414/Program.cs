using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _414
{
    class Program
    {
/*
165 182 173 173 168
2 5
*/

        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] pos = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int left = pos[0]-1, right = pos[1]-1;
            arr=arr.OrderByDescending(x => x).ToArray();
            Console.WriteLine($"{arr[left]} {arr[right]}");
        }
    }
}
