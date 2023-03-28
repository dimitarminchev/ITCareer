namespace CrossRun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] day1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] day2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] result = day1.Concat(day2).ToArray().OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}