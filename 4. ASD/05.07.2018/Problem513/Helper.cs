using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem513
{
    class Helper
    {
        // BinarySearch
        public static int BinarySearch(int[] array, int n, int val)
        {
            int mid, low = 0, high = n - 1, geq = -1;
            while (low <= high)
            {
                mid = (low + high) >> 1; // mid=(low+high)/2;
                if (val < array[mid])
                {
                    high = mid - 1;
                    geq = mid;
                }
                else if (val > array[mid]) low = mid + 1;
                else return mid; // found 
            }

            return geq; // not found 
        }

        // FibonacciSearch
        public static int FibonacciSearch(int[] array, int n, int val)
        {
            int k, idx, offs, prevn = -1, prevk = -1;

            //  Precomputed Fibonacci numbers up to F46
            int[] Fib = new int[] {0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765,
             10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, 514229, 832040, 1346269, 2178309, 3524578,
             5702887, 9227465, 14930352, 24157817, 39088169, 63245986, 102334155, 165580141, 267914296,
             433494437, 701408733, 1134903170, 1836311903 };

            // find the smallest fibonacci number that is greater or equal to n
            if (n != prevn)
            {
                if (n > 1) k = BinarySearch(Fib, Fib.Count() / sizeof(int), n);
                else k = 1;
                prevk = k;
                prevn = n;
            }
            else k = prevk;


            /* If the sought value is larger than the largest Fibonacci number less than n,
             * care must be taken top ensure that we do not attempt to read beyond the end
             * of the array. If we do need to do this, we pretend that the array is padded
             * with elements larger than the sought value.
             */
            for (offs = 0; k > 0;)
            {
                idx = offs + Fib[--k];

                /* note that at this point k  has already been decremented once */
                if (idx >= n || val < array[idx]) continue;
                else if (val > array[idx])
                {
                    offs = idx;
                    --k;
                }
                else return idx; // found
            }

            return -1; // not found
        }
    }
}
