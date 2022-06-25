using System;
namespace CircularQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Кръгова опашка с числа
            CircularQueue<int> numbers = new CircularQueue<int>();
            numbers.Enqueue(112);
            numbers.Enqueue(911);
            numbers.Enqueue(166);
            numbers.Enqueue(150);
            Console.WriteLine(string.Join(" ", numbers));

            // Кръгова опашка с текст
            CircularQueue<string> text = new CircularQueue<string>();
            text.Enqueue("Hello");
            text.Enqueue("World");
            Console.WriteLine(string.Join(" ", text));

        }
    }
}