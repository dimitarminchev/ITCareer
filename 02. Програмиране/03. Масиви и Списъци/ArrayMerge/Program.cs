namespace ArrayMerge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] B = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] C = new int[A.Length + B.Length];

            for (int i = 0; i < A.Length; i++)
            {
                C[i] = A[i];
            }

            for (int i = A.Length; i < A.Length + B.Length; i++)
            {
                C[i] = B[i - A.Length];
            }

            for (int i = 0; i < C.Length; i++)
            {
                for (int j = 0; j < C.Length; j++)
                {
                    if (C[i] < C[j])
                    {
                        int temp = C[i];
                        C[i] = C[j];
                        C[j] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", C));
        }
    }
}