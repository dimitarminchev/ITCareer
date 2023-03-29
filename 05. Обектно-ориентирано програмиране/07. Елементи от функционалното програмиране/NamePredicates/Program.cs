namespace NamePredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] ime = Console.ReadLine().Split(' ').ToArray();
            Console.WriteLine(string.Join("\n", ime.Where(x => x.Length <= n)));
        }
    }
}