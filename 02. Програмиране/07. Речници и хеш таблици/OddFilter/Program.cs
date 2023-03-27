namespace OddFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var even = num.Where(x => x % 2 == 0).ToArray();
            var avg = even.Average();

            var num1 = even.Where(x => x <= avg).Select(y => y = y - 1).ToArray();
            var num2 = even.Where(x => x > avg).Select(y => y = y + 1).ToArray();
            var num3 = num1.Concat(num2);

            Console.WriteLine(string.Join(" ", num3));
        }
    }
}