namespace BonusPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            var num = double.Parse(Console.ReadLine());

            var bonusScore = 0.0;
            if (num <= 100) bonusScore = 5;
            else if (num <= 1000) bonusScore = num * 0.2;
            else bonusScore = num * 0.1;

            if (num % 10 == 5) bonusScore += 2;
            else if (num % 2 == 0) bonusScore += 1;

            Console.WriteLine("Bonus score: {0}", bonusScore);
            Console.WriteLine("Total score: {0}", num + bonusScore);
        }
    }
}