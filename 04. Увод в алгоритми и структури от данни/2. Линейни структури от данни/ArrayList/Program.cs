namespace ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> integers = new ArrayList<int>();
            integers.Add(112);
            integers.Add(911);
            integers.Add(166);
            integers.Add(150);
            Console.WriteLine("Integers: {0}", string.Join(" ", integers));

            ArrayList<string> strings = new ArrayList<string>();
            strings.Add("Hello");
            strings.Add("World");
            Console.WriteLine("Strings: {0}", string.Join(" ", strings));
        }
    }
}