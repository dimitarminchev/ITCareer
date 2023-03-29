namespace ArrayCreator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array of Strings
            string[] strings = ArrayCreator.Create(5, "Pesho");
            Console.WriteLine(string.Join(", ", strings));

            // Array of Integers
            int[] integers = ArrayCreator.Create(10, 42);
            Console.WriteLine(string.Join(", ", integers));
        }
    }
}