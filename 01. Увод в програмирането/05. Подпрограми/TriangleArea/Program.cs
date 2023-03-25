namespace TriangleArea
{
    internal class Program
    {
        static double Area(double a, double ha)
        {
            return (a * ha) / 2;
        }

        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var ha = double.Parse(Console.ReadLine());
            var s = Area(a, ha);
            Console.WriteLine(s);
        }
    }
}