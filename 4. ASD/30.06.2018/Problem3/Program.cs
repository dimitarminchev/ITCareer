using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            // O(N)
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int mid = 0, l = 0, r = arr.Length - 1;

            // Start of Binary Search = O(log(N))
            while (l <= r)
            {
                mid = (l + r) / 2;
                if (arr[mid] == n)
                {
                    Console.WriteLine("{0} exsists in the array", n);
                    return;
                }
                if (arr[mid] < n) r = mid - 1;
                else l = mid + 1;
            }
            Console.WriteLine("{0} does not exsist in the array", n);

            // Total: O(log(N))
        }
    }
}
