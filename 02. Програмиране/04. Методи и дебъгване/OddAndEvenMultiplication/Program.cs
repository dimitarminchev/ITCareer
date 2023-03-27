namespace OddAndEvenMultiplication
{
    internal class Program
    {
        private static int GetSumOfEvenDigits(int n)
        {
            n = Math.Abs(n); // fix
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum = sum + lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        private static int GetSumOfOddDigits(int n)
        {
            n = Math.Abs(n); // fix
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum = sum + lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        private static int GetMultiplePfEvensAndOdds(int n)
        {
            int sumEvens = GetSumOfEvenDigits(n);
            int sumOdds = GetSumOfOddDigits(n);
            return sumEvens * sumOdds;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int product = GetMultiplePfEvensAndOdds(n);
            Console.WriteLine(product);
        }
    }
}