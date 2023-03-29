namespace AddVAT
{
    class Program
    {
        /// <summary>
        /// Add VAT
        /// https://judge.softuni.org/Contests/Practice/Index/597#3
        /// </summary>
        static void Main(string[] args)
        {
            Console.ReadLine()
                   .Split(new string[] { ", " },
                    StringSplitOptions.RemoveEmptyEntries)
                   .Select(double.Parse)
                   .Select(n => n * 1.2)
                   .ToList()
                   .ForEach(n => Console.WriteLine($"{n:F2}"));
        }
    }
}