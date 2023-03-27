namespace SquareNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var squareNums = numbers.Where(x => Math.Sqrt(x) % 1 == 0).ToList();

            squareNums.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", squareNums));
        }
    }
}