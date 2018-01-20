using System;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Проверка за просто число
            int n = int.Parse(Console.ReadLine());
            if(n <= 1)
            {
                Console.WriteLine("Not Prime");
                return;
            }
            bool prime = true;
            for (int k = 2; k <= Math.Sqrt(n); k++) // fix(1): K<N = K<SQRT(N)
                if (n % k == 0)
                {
                    prime = false;
                    break; // fix(2): DO NOT TEST OTHER NUMBERS!
                }            
            if (prime) Console.WriteLine("Prime");
            else Console.WriteLine("Not Prime");
        }
    }
}
