namespace ArrayStatistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double min = 1000, max = -1000, sum = 0;
            int[] arr = new int[n];

            for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                sum = sum + arr[i];
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }

            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(sum);
            Console.WriteLine(sum / n);
        }
    }
}