namespace NumberOfInversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] > a[j] && i < j) count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}