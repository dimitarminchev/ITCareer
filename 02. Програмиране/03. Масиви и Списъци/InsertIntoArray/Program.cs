namespace InsertIntoArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] B = new int[A.Length + 1];
            int placed = 0;
            for (int i = 0; i < B.Length; i++)
            {
                if (n >= A[i - placed] || placed == 1)
                {
                    B[i] = A[i - placed];
                }
                else
                {
                    B[i] = n;
                    placed = 1;
                }
            }
            Console.WriteLine(string.Join(" ", B));
        }
    }
}