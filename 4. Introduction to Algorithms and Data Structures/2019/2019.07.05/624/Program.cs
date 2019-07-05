using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _624
{
    class Program
    {
        // 624 = Vectors 0/1
        static void printArray(int[] arr, int n) 
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void generateAll(int n, int[] arr, int i)
        {
            if (i == n)
            {
                printArray(arr, n);
                return;
            }
            arr[i] = 0;
            generateAll(n, arr, i + 1);
            arr[i] = 1;
            generateAll(n, arr, i + 1);
        }

        public static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            generateAll(n, arr, 0);
        }
    }
}
