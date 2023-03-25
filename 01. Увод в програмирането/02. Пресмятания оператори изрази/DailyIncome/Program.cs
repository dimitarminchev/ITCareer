namespace DailyIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Days = double.Parse(Console.ReadLine());
            var Money = double.Parse(Console.ReadLine());
            var UsdBgn = double.Parse(Console.ReadLine());

            var Income = ((Days * Money) * 12) + ((Days * Money) * 2.5);
            var Tax = Income * 0.25;
            var PerDay = ((Income - Tax) * UsdBgn) / 365;

            Console.WriteLine($"{PerDay:f2}");
        }
    }
}