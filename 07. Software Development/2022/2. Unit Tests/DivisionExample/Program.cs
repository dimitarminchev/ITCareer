using System;

namespace DivisionExample 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Divider div = new Divider();

            // Ръчен тест
            Console.WriteLine("4/2={0}", div.Divide(4,2));
        }
    }
}