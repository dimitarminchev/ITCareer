namespace SumOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                var next = int.Parse(Console.ReadLine());
                sum = sum + next;
            }
            Console.WriteLine(sum);
        }
    }
}