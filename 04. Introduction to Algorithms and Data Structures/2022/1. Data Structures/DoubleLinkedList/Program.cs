using System;
namespace DoubleLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Обратен списък с числа
            DoubleLinkedList<int> numbers = new DoubleLinkedList<int>();
            numbers.AddFirst(112);
            numbers.AddFirst(911);
            numbers.AddFirst(166);
            numbers.AddFirst(150);
            Console.WriteLine(string.Join(" ", numbers));

            // Обратен списък с текст
            DoubleLinkedList<string> text = new DoubleLinkedList<string>();
            text.AddFirst("Hello");
            text.AddFirst("World");
            Console.WriteLine(string.Join(" ", text));

        }
    }
}