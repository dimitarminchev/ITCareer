using System;
namespace ArrayStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Разтеглив масив с числа
            ArrayStack<int> numbers = new ArrayStack<int>();
            numbers.Push(112);
            numbers.Push(911);
            numbers.Push(166);
            numbers.Push(150);
            Console.WriteLine(string.Join(" ", numbers));

            // Разтеглив масив с текст
            ArrayStack<string> text = new ArrayStack<string>();
            text.Push("Hello");
            text.Push("World");
            Console.WriteLine(string.Join(" ", text));

        }
    }
}