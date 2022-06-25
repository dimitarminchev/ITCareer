using System;
namespace LinkedStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Свързан стек с числа
            LinkedStack<int> numbers = new LinkedStack<int>();
            numbers.Push(112);
            numbers.Push(911);
            numbers.Push(166);
            numbers.Push(150);
            Console.WriteLine(string.Join(" ", numbers));

            // Свързан стек с текст
            LinkedStack<string> text = new LinkedStack<string>();
            text.Push("Hello");
            text.Push("World");
            Console.WriteLine(string.Join(" ", text));
        }
    }
}