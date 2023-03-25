namespace RectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var h = Math.Max(y1, y2) - Math.Min(y1, y2);
            var w = Math.Max(x1, x2) - Math.Min(x1, x2);
            var s = h * w;
            var p = 2 * (h + w);

            Console.WriteLine(s);
            Console.WriteLine(p);
        }
    }
}