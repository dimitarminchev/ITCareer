namespace Needles
{
    internal class Program
    {
        public static int RealNumber(int startIndex, int[] arr)
        {
            for (int i = startIndex; i < arr.Length; i++)
            {
                if (arr[i] != 0) return arr[i];
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int N = array[0], C = array[1];
            int[] numbers = new int[N];
            numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] needles = new int[C];
            needles = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] newArray = new int[C + N];
            for (int i = 0; i < C; i++)
            {
                for (int y = 0; y < N - 1; y++)
                {
                    if (needles[i] <= numbers[0] && numbers[0] != 0)
                    {
                        Console.Write(0 + " "); break;
                    }
                    if (needles[i] > numbers[numbers.Length - 1] && numbers[numbers.Length - 1] != 0)
                    {
                        Console.Write(numbers.Length + " "); break;
                    }
                    if (numbers[y] != 0 && needles[i] >= numbers[y] && needles[i] <= RealNumber(y + 1, numbers))
                    {
                        Console.Write(y + 1 + " "); break;
                    }
                }
            }
        }
    }
}