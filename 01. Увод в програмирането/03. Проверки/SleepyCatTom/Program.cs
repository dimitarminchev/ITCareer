namespace SleepyCatTom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int playtime = (365 - days) * 63 + days * 127;
            int h = Math.Abs((30000 - playtime) / 60);
            int m = Math.Abs((30000 - playtime) % 60);

            if (playtime < 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", h, m);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", h, m);
            }
        }
    }
}