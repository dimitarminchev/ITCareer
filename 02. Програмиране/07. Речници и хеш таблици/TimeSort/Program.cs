namespace TimeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] item = Console.ReadLine().Split(' ');
            item = item.OrderBy(x => x).Distinct().ToArray();
            Console.WriteLine(string.Join(" ", item));
        }
    }
}