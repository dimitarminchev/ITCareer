namespace MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var max = -1000;
            for (int i = 0; i < n; i++)
            {
                var next = int.Parse(Console.ReadLine());
                if (next > max) max = next;
            }
            Console.WriteLine(max);
        }
    }
}