using System;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Числа – степени на 2
            int n = int.Parse(Console.ReadLine());
            int step2 = 1;
            while(n >= 0)
            {
                Console.WriteLine(step2);
                step2 *= 2;
                n--;
            }
        }
    }
}
