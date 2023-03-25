namespace EvenOddSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var oddSum = 0;
            var evenSum = 0;
            for (var i = 0; i < n; i++)
            {
                var element = int.Parse(Console.ReadLine());
                if (i % 2 == 0) oddSum += element;
                else evenSum += element;
            }
            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes, sum = " + oddSum);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(oddSum - evenSum));
            }
        }
    }
}