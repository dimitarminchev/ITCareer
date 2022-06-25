using System;
namespace ReversedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Обратен списък с числа
            ReversedList<int> numbers = new ReversedList<int>();
            numbers.Add(112);
            numbers.Add(911);
            numbers.Add(166);
            numbers.Add(150);
            Console.WriteLine(string.Join(" ", numbers));

            // Обратен списък с текст
            ReversedList<string> text = new ReversedList<string>();
            text.Add("Hello");
            text.Add("World");
            Console.WriteLine(string.Join(" ", text));

        }
    }
}