namespace TrapecoidArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var b1 = double.Parse(Console.ReadLine());
            var b2 = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var Area = (b1 + b2) * h / 2;
            Console.WriteLine("Trapecoid Area = {0}", Area);
        }
    }
}