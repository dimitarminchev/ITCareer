namespace Raindrops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var regions = int.Parse(Console.ReadLine());
            var density = float.Parse(Console.ReadLine());
            var regionalCoefficient = new List<float>();

            while (regions > 0)
            {
                var line = Console.ReadLine().Split().Select(float.Parse).ToArray();
                var raindropsCount = line[0];
                var squareMeters = line[1];
                regionalCoefficient.Add(raindropsCount / squareMeters);
                regions--;
            }

            var sum = regionalCoefficient.Sum();
            Console.WriteLine("{0:f3}", sum / density);
        }
    }
}