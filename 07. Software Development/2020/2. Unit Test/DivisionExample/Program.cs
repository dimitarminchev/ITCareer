using System;

namespace DivisionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Divider div = new Divider();
            Console.WriteLine("4/2={0}", div.Divide(4, 2));
            Console.WriteLine("4/0={0}", div.Divide(4, 0));
        }
    }
}
