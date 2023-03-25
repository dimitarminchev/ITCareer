namespace MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var min = 1000;
            for (int i = 0; i < n; i++)
            {
                var next = int.Parse(Console.ReadLine());
                if (next < min) min = next;
            }
            Console.WriteLine(min);
        }
    }
}