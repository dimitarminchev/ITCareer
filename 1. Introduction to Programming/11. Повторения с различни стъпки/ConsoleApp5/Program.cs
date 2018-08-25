using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Редица числа 2k+1
            var n = int.Parse(Console.ReadLine());
            var k = 0;
            while( k <= n )
            {
                k = 2 * k + 1;
                if(k <= n) Console.WriteLine(k);
            }
        }
    }
}
