namespace SquareArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("а=");
            var a = int.Parse(Console.ReadLine());
            var area = a * a;
            Console.Write("Area = ");
            Console.WriteLine(area);
        }
    }
}