namespace TriangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var s = Math.Round(a * h / 2, 2);
            Console.WriteLine("Triangle area = {0}", s);
        }
    }
}