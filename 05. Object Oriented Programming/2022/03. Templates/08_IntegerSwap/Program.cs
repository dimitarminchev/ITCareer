namespace _08_IntegerSwap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input Integer Numbers
            int n = int.Parse(Console.ReadLine());
            IntegerSwap<int> strings = new IntegerSwap<int>(n);
            for (int i = 0; i < n; i++)
            {
                strings.Add(int.Parse(Console.ReadLine()));
            }

            // Get the position to swap
            var pos = Console.ReadLine().Split().ToArray();
            int first = int.Parse(pos[0]);
            int second = int.Parse(pos[1]);

            // Swap Elements and Print
            strings.Swap(first, second);
            strings.Print();
        }
    }
}