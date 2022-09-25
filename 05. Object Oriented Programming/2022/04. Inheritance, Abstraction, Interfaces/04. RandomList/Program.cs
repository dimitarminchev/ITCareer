namespace _04._RandomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create random list instance
            RandomList list = new RandomList();

            // Add some data to the list
            list.Add(42); // int
            list.Add("fourty two"); // string
            list.Add(3.14); // float
            list.Add(true);

            // Print the content of the list
            Console.WriteLine(String.Join(", ", list.ToArray()));

            // Randomly remove element from the list
            Console.WriteLine(list.RandomObject());
            Console.WriteLine(list.RandomObject());
        }
    }
}