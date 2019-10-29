using System;
using System.Linq;

namespace _04_AddVAT
{
    class Program
    {
        // 04. Add VAT
        // https://judge.softuni.bg/Contests/Practice/Index/597#3
        static void Main(string[] args)
        {
            // String To Double Delegate
            Func<string, double> parser =  str => double.Parse(str);

            // Value Added Tax Delegate
            Func<double, double> vat = price => price * 1.2; 

            // Process and print
            Console.ReadLine()
                .Split(new string[] { ", " },StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)
                .Select(vat)
                .ToList()
                .ForEach(n => Console.WriteLine($"{n:F2}"));
        }
    }
}
