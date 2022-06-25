using System;
namespace ArrayList 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Разтеглив масив с числа
            ArrayList<int> numbers = new ArrayList<int>();
            numbers.Add(112);
            numbers.Add(911);
            numbers.Add(166);
            numbers.Add(150);
            Console.WriteLine(string.Join(" ", numbers));

            // Разтеглив масив с текст
            ArrayList<string> text = new ArrayList<string>();
            text.Add("Hello");
            text.Add("World");
            Console.WriteLine(string.Join(" ", text));

        }
    }
}