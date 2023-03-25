namespace CircleAreaAndPerimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Radius = ");
            var r = double.Parse(Console.ReadLine());
            var area = Math.PI * r * r;
            var perimeter = 2 * Math.PI * r;
            Console.WriteLine("Area = {0}", area);
            Console.WriteLine("Perimeter = {0}", perimeter);
        }
    }
}