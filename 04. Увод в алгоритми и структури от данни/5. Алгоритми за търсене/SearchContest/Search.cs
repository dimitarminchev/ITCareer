namespace SearchContest
{
    public class Search
    {
        public static int Linear<T>(T[] elements, T key) where T : IComparable
        {
            for (int index = 0; index < elements.Count(); index++)
            {
                if (elements[index].CompareTo(key) == 0)
                {
                    return index;
                }
            }
            return -1;
        }

        public static int Binary<T>(T[] elements, T key) where T : IComparable
        {
            int start = 0, end = elements.Count() - 1;
            while (end >= start)
            {
                int mid = (start + end) / 2;

                if (elements[mid].CompareTo(key) > 0)
                {
                    end = mid - 1;
                }
                else if (elements[mid].CompareTo(key) < 0)
                {
                    start = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }

        public static int Interpolational(int[] sortedArray, int key)
        {
            int low = 0;
            int high = sortedArray.Length - 1;
            while (sortedArray[low] <= key && sortedArray[high] >= key)
            {
                int mid = (int)(low + ((double)(key - sortedArray[low]) * (high - low)) / (sortedArray[high] - sortedArray[low]));
                if (sortedArray[mid] < key) low = mid + 1;
                else if (sortedArray[mid] > key) high = mid - 1;
                else return mid;
            }
            if (sortedArray[low] == key) return low;
            else return -1;
        }

        public static long Fibonacci(int[] arr, int x, int n)
        {
            long fibMMm2 = 0;
            long fibMMm1 = 1;
            long fibM = fibMMm2 + fibMMm1;
            while (fibM < n)
            {
                fibMMm2 = fibMMm1;
                fibMMm1 = fibM;
                fibM = fibMMm2 + fibMMm1;
            }
            long offset = -1;
            while (fibM > 1)
            {
                long i = offset + fibMMm2 > n - 1 ? n - 1 : offset + fibMMm2;
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