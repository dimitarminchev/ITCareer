namespace ThousandDaysOnEarth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            DateTime time = DateTime.ParseExact(date, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            time = time.AddDays(999);
            Console.WriteLine(time.ToString("dd-MM-yyyy"));
        }
    }
}