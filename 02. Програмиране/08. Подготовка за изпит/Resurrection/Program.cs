namespace Resurrection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                int totalLength = int.Parse(Console.ReadLine());
                float totalWidth = float.Parse(Console.ReadLine());
                int wingLength = int.Parse(Console.ReadLine());

                decimal totalYears = (decimal)((totalLength * totalLength) * (totalWidth + (2 * wingLength)));
                Console.WriteLine(totalYears);
                n--;
            }
        }
    }
}