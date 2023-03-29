namespace RandomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();
            list.Add(42); // int
            list.Add("fourty two"); // string
            list.Add(3.14); // float
            list.Add(true); // bool
            Console.WriteLine(String.Join(", ", list.ToArray()));
            Console.WriteLine(list.RandomObject());
            Console.WriteLine(list.RandomObject());
        }
    }
}