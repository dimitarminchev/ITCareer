using System;
namespace DynamicList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Динамичен списък с цисла
            DynamicList numbers = new DynamicList();
            numbers.Add(112);
            numbers.Add(911);
            numbers.Add(166);
            numbers.Add(150);
            foreach (var item in numbers)
            {
                Console.Write("{0} ",item);
            }
            // Console.WriteLine(string.Join(" ", numbers));

            // Динамичен списък с тест
            DynamicList text = new DynamicList();
            text.Add("Hello");
            text.Add("World");
            foreach (var item in text)
            {
                Console.Write("{0} ", item);
            }
            // Console.WriteLine(string.Join(" ", text));

        }
    }
}