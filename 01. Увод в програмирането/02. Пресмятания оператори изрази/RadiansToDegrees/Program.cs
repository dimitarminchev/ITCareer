namespace RadiansToDegrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Radians = ");
            var Radians = double.Parse(Console.ReadLine());
            var Degrees = (Radians * 180) / Math.PI;
            Console.WriteLine("Degrees = {0}", Degrees);
        }
    }
}