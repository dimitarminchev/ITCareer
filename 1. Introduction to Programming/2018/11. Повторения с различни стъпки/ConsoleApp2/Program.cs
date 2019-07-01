using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Числата от N до 1 в обратен ред 
            int n = int.Parse(Console.ReadLine());
            int k = n;
            while(k > 0)
            {
                Console.WriteLine(k);
                k--; 
            }
        }
    }
}
