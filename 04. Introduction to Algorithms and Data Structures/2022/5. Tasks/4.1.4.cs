using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _414
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 165 182 173 173 168
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // 2 5
            int[] pos = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int left = pos[0]-1, right = pos[1]-1;

            // Sort
            arr=arr.OrderByDescending(x => x).ToArray();

            Console.WriteLine($"{arr[left]} {arr[right]}");
        }
    }
}
