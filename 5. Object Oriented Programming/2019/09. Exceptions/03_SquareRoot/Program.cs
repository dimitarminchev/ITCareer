using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            try
            {
                if (n < 0) throw new Exception("Invalid number.");
                double sqrt = Math.Sqrt(n);
                Console.WriteLine(sqrt);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Good bye.");
            }
        }
    }
}
