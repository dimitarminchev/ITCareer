namespace ReversedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ReversedList<int> integers = new ReversedList<int>();
            integers.Add(112);
            integers.Add(911);
            integers.Add(166);
            integers.Add(150);
            Console.WriteLine("Integers: {0}", string.Join(" ", integers));

            ReversedList<string> strings = new ReversedList<string>();
            strings.Add("Hello");
            strings.Add("World");
            Console.WriteLine("Strings: {0}", string.Join(" ", strings));
        }
    }
}