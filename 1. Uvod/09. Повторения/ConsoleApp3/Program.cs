using System;
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Всички латински букви
            Console.Write("Latin alphabet:");
            for (var a = 'a'; a <= 'z'; a++)
            {
                Console.Write(" "+a);
            }
        }
    }
}
