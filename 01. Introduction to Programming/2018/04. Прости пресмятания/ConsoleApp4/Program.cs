using System;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Лице на триъгълник
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var s = Math.Round(a * h / 2,2);
            Console.WriteLine("Triangle area = {0}", s);
        }
    }
}
