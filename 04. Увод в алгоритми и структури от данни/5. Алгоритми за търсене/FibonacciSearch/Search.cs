namespace FibonacciSearch
{
    static class Search
    {
        public static int Fibonacci(int[] arr, int x, int n)
        {
            int fibMMm2 = 0;
            int fibMMm1 = 1;
            int fibM = fibMMm2 + fibMMm1;

            while (fibM < n)
            {
                fibMMm2 = fibMMm1;
                fibMMm1 = fibM;
                fibM = fibMMm2 + fibMMm1;
            }

            int offset = -1;

            while (fibM > 1)
            {
                int i = Math.Min(offset + fibMMm2, n - 1);

                if (arr[i] < x)
                {
                    fibM = fibMMm1;
                    fibMMm1 = fibMMm2;
                    fibMMm2 = fibM - fibMMm1;
                    offset = i;
                }

                else if (arr[i] > x)
                {
                    fibM = fibMMm2;
                    fibMMm1 = fibMMm1 - fibMMm2;
                    fibMMm2 = fibM - fibMMm1;
                }

                else return i;
            }

            if (fibMMm1 != 0 && arr[offset + 1] == x) return offset + 1;

            return -1;
        }
    }
}
