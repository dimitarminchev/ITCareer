namespace MinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Func<int[]> input = () => Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                Action<int[]> min = (inp) => Console.WriteLine(inp.Min());
                min(input());
            }
        }
    }
}