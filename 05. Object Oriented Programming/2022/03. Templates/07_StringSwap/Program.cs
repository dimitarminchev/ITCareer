namespace _07_StringSwap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input Stings
            int n = int.Parse(Console.ReadLine());
            StringSwap<string> strings = new StringSwap<string>(n);
            for (int i = 0; i < n; i++)
            {
                strings.Add(Console.ReadLine());
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