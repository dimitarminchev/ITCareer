using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_EnterNumbers
{
    class Program
    {
        public static void ReadNumber(int start, int end)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < start || n > end) throw new InvalidOperationException($"Number must be in range {start} - {end}");
        }
        
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    ReadNumber(s, e);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
