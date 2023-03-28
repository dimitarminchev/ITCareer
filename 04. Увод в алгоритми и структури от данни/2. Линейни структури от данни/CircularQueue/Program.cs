namespace CircularQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularQueue<int> integers = new CircularQueue<int>();
            integers.Enqueue(112);
            integers.Enqueue(911);
            integers.Enqueue(166);
            integers.Enqueue(150);
            Console.WriteLine("Integers: {0}", string.Join(" ", integers));

            CircularQueue<string> strings = new CircularQueue<string>();
            strings.Enqueue("Hello");
            strings.Enqueue("World");
            Console.WriteLine("Strings: {0}", string.Join(" ", strings));
        }
    }
}