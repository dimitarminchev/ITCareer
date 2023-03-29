namespace IntegerSwap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            IntegerSwap<int> strings = new IntegerSwap<int>(n);
            for (int i = 0; i < n; i++)
            {
                strings.Add(int.Parse(Console.ReadLine()));
            }

            var pos = Console.ReadLine().Split().ToArray();
            int first = int.Parse(pos[0]);
            int second = int.Parse(pos[1]);

            strings.Swap(first, second);
            strings.Print();
        }
    }
}