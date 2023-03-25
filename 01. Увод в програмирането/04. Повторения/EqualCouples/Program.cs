namespace EqualCouples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var max = 0;
            var sum = a + b;
            var prev = sum;
            for (int i = 0; i < n - 1; i++)
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                sum = a + b;
                if (max < Math.Abs(sum - prev))
                {
                    max = Math.Abs(prev - sum);
                    prev = sum;
                }
            }
            if (max == 0) Console.WriteLine("Yes, value=" + prev);
            else Console.WriteLine("No, maxdiff=" + max);
        }
    }
}