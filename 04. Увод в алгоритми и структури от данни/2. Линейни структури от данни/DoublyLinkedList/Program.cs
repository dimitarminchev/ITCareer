namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList<int> integers = new DoubleLinkedList<int>();
            integers.AddFirst(112);
            integers.AddFirst(911);
            integers.AddFirst(166);
            integers.AddFirst(150);
            Console.WriteLine("Integers: {0}", string.Join(" ", integers));

            DoubleLinkedList<string> strings = new DoubleLinkedList<string>();
            strings.AddFirst("Hello");
            strings.AddFirst("World");
            Console.WriteLine("Strings: {0}", string.Join(" ", strings));
        }
    }
}