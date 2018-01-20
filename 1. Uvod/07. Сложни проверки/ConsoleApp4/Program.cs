using System;


namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Плод или зеленчук
            var name = Console.ReadLine().ToLower();
            switch (name)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                {
                        Console.WriteLine("fruit");
                        break;
                }
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                {
                        Console.WriteLine("vegetable");
                        break;
                }
                default: { Console.WriteLine("unknown");  break;  }
            };

        }
    }
}
