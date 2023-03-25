namespace RectangleOfNxNStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            // v1
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', n));
            }

            // v2
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}