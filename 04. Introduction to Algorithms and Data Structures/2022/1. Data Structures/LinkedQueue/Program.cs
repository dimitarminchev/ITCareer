using System;
namespace LinkedQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Свързана опашка с числа
            LinkedQueue<int> numbers = new LinkedQueue<int>();
            numbers.Enqueue(112);
            numbers.Enqueue(911);
            numbers.Enqueue(166);
            numbers.Enqueue(150);
            Console.WriteLine(string.Join(" ", numbers));

            // Свързана опашка с текст
            LinkedQueue<string> text = new LinkedQueue<string>();
            text.Enqueue("Hello");
            text.Enqueue("World");
            Console.WriteLine(string.Join(" ", text));
        }
    }
}