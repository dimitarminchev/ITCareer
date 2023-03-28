namespace HanoiTowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfDisks = int.Parse(Console.ReadLine());

            Stack<int> source = new Stack<int>(Enumerable.Range(1, numberOfDisks).Reverse());
            Stack<int> destination = new Stack<int>();
            Stack<int> spare = new Stack<int>();

            PrintRods(source, destination, spare);
            MoveDisks(numberOfDisks, source, destination, spare);
            PrintRods(source, destination, spare);
        }

        private static void PrintRods(Stack<int> source, Stack<int> destination, Stack<int> spare)
        {
            Console.WriteLine("Source: {0}", string.Join(", ", source.Reverse()));
            Console.WriteLine("Spare: {0}", string.Join(", ", spare.Reverse()));
            Console.WriteLine("Destination: {0}", string.Join(", ", destination.Reverse()));
            Console.WriteLine();
        }

        private static void MoveDisks(int bottomDisk, Stack<int> source, Stack<int> destination, Stack<int> spare)
        {
            if (bottomDisk == 1)
            {
                destination.Push(source.Pop());
                PrintRods(source, destination, spare);
                return;
            }

            MoveDisks(bottomDisk - 1, source, spare, destination);
            PrintRods(source, destination, spare);

            destination.Push(source.Pop());
            PrintRods(source, destination, spare);

            MoveDisks(bottomDisk - 1, spare, destination, source);
            PrintRods(source, destination, spare);
        }
    }
}