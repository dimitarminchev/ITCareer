using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Обръщение спрямо пол и възраст
            var age = double.Parse(Console.ReadLine());
            var gender = Console.ReadLine();
            if(age < 16)
            {
                if (gender == "m") Console.WriteLine("Master");
                else if (gender == "f") Console.WriteLine("Miss");
            }
            else
            {
                if (gender == "m") Console.WriteLine("Mr.");
                else if (gender == "f") Console.WriteLine("Ms.");
            }
        }
    }
}
