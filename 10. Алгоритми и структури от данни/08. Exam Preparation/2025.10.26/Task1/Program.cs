using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("Mariyka");
            }
            else
            {
                Console.WriteLine("Ivancho");
            }
        }
    }
}
