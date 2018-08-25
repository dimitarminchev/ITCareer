using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Лице на трапец
            var b1 = double.Parse(Console.ReadLine());
            var b2 = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var s = (b1 + b2) * h / 2.0;
            Console.WriteLine("Trapezoid Area = {0}", s);
        }
    }
}
