using System;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Лице и периметър на кръг
            var r = double.Parse(Console.ReadLine());
            var s = Math.Round(Math.PI*r*r,2);
            var p = Math.Round(2*Math.PI*r,2);
            Console.WriteLine("Area = {0}", s);
            Console.WriteLine("Perimeter = {0}", p);
        }
    }
}
