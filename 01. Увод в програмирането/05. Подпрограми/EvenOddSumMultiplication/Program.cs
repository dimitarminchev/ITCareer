namespace EvenOddSumMultiplication
{
    internal class Program
    {
        static double GetSumOfEvenDigits(int n)
        {
            double sum = 0;
            while (n > 0)
            {
                if ((n % 10) % 2 == 0) sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        static double GetSumOfOddDigits(int n)
        {
            double sum = 0;
            while (n > 0)
            {
                if ((n % 10) % 2 != 0) sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        static double GetMultipleOfEvensAndOdds(int n)
        {
            return GetSumOfEvenDigits(n) * GetSumOfOddDigits(n);
        }

        static void Main(string[] args)
        {
            var n = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvensAndOdds(n));
        }
    }
}