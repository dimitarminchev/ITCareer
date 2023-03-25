namespace HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var m = Console.ReadLine();
            var brn = int.Parse(Console.ReadLine());
            double PS = 0;
            double PA = 0;
            if (m == "May" || m == "October")
            {
                PS *= 50;
                PA *= 65;
                if (brn > 5 && brn <= 14) PS *= 0.95;
                if (brn > 14)
                {
                    PS *= 0.7;
                    PA *= 0.9;
                }
            }
            else if (m == "June" || m == "September")
            {
                PS *= 75.2;
                PA *= 68.7;
                if (brn > 14)
                {
                    PS *= 0.8;
                    PA *= 0.9;
                }
            }
            else
            {
                PS *= 76;
                PA *= 77;
                if (brn > 14) PA *= 0.9;
            }
            Console.WriteLine("Apartment: {0:f2}", PA);
            Console.WriteLine("Studio: {0:f2}", PS);
        }
    }
}