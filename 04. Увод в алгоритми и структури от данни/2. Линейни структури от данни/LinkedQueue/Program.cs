namespace LinkedQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedQueue<int> integers = new LinkedQueue<int>();
            integers.Enqueue(112);
            integers.Enqueue(911);
            integers.Enqueue(166);
            integers.Enqueue(150);
            Console.WriteLine("Integers: {0}", string.Join(" ", integers));

            LinkedQueue<string> strings = new LinkedQueue<string>();
            strings.Enqueue("Hello");
            strings.Enqueue("World");
            Console.WriteLine("Strings: {0}", string.Join(" ", strings));
        }
    }
}