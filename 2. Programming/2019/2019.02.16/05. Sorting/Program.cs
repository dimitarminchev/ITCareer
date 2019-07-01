using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sorting
{
    class Program
    {
        // 5. Сортиране
        static void Main(string[] args)

        {
            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Sort
            for (int i = 0; i < A.Length; i++)
                for (int j = 0; j < A.Length; j++)
                    if (A[i] < A[j])
                    {
                        int temp = A[i];
                        A[i] = A[j];
                        A[j] = temp;
                    }

            Console.WriteLine(string.Join(" ",A));
        }
    }
}
