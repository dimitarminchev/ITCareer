namespace UserComparator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ime = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] even = ime.Where(x => x % 2 == 0).OrderBy(x => x).ToArray();
            int[] odd = ime.Where(x => x % 2 != 0).OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(" ", even.Concat(odd)));
        }
    }
}