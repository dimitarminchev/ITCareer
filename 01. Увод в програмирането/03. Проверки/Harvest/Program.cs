namespace Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var z = double.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var h = (x * y) * 0.4;
            var w = (h / 2.5);
            if (w >= z)
            {
                var left = w - z;
                Console.WriteLine("Good harvest this year!Total wine: {0}  liters.", w);
                Console.WriteLine("{0} liters left -> liters per person.", Math.Ceiling(left), left / workers);
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", z - w);
            }
        }

    }
}