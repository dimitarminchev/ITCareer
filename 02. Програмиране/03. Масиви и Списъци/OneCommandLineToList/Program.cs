namespace OneCommandLineToList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            Console.WriteLine(string.Join(", ", list));
        }
    }
}