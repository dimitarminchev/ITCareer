namespace ArrayStack
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayStack<int> integers = new ArrayStack<int>();
            integers.Push(112);
            integers.Push(911);
            integers.Push(166);
            integers.Push(150);
            Console.WriteLine("Integers: {0}", string.Join(" ", integers));

            ArrayStack<string> strings = new ArrayStack<string>();
            strings.Push("Hello");
            strings.Push("World");
            Console.Write("Strings: ");
            Console.WriteLine("Strings: {0}", string.Join(" ", strings));
        }
    }
}