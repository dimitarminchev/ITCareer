namespace PrimeNumberCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var k = int.Parse(Console.ReadLine());
            var prime = true;
            for (int j = 2; j < k; j++)
                if (k % j == 0)
                    prime = false;
            if (prime && k > 1) Console.WriteLine("Prime");
            else Console.WriteLine("Not Prime");
        }
    }
}