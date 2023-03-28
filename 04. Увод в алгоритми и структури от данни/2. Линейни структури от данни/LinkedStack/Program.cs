namespace LinkedStack
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedStack<int> integers = new LinkedStack<int>();
            integers.Push(112);
            integers.Push(911);
            integers.Push(166);
            integers.Push(150);
            Console.WriteLine("Integers: {0}", string.Join(" ", integers));

            LinkedStack<string> strings = new LinkedStack<string>();
            strings.Push("Hello");
            strings.Push("World");
            Console.WriteLine("Strings: {0}", string.Join(" ", strings));
        }
    }
}