using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MergeSortedArrays
{
    class Program
    {
        // 4. Сливане на подредени масиви
        static void Main(string[] args)
        {
            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] B = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] C = new int[A.Length + B.Length];

            // Merge
            for (int i = 0; i < A.Length; i++)
                C[i] = A[i];
            for (int i = A.Length; i < A.Length + B.Length; i++)
                C[i] = B[i - A.Length];

            // Sort
            for (int i = 0; i < C.Length; i++)
                for (int j = 0; j < C.Length; j++)
                    if (C[i] < C[j])
                    {
                        int temp = C[i];
                        C[i] = C[j];
                        C[j] = temp;
                    }

            // Print
            Console.WriteLine(string.Join(" ", C));
        }
    }
}
