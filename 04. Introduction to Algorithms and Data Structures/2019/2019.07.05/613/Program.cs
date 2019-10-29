using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _613
{
    class Program
    {
        static void GetCombinations(int[] arr, int index, int start, int end)
        {
            if (index >= arr.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                    if (i < arr.Length - 1) Console.Write("{0} ", arr[i]);
                    else Console.WriteLine(arr[i]);
            }
            else
                for (int i = start; i <= end; i++)
                {
                    arr[index] = i;
                    GetCombinations(arr, index + 1, i, end);
                }
        }
        // 613 = Combinations with Repetitions
        static void Main(string[] args)
        {
            Console.Write("ENter N:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("ENter K:");
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[k];
            GetCombinations(arr, 0, 1, n);
        }
    }
}
