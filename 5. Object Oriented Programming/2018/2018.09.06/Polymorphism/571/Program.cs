using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _571
{
    public static class Console
    {
        public static string ReadLine()
        {
            return System.Console.ReadLine();
        }
        public static void WriteLine(object text)
        {
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(text);
            System.Console.ResetColor();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split().ToArray();
            while (line[0] != "End")
            {
                string[] foodLine = Console.ReadLine().Split().ToArray();
                Animal animal;
                Food food;
                if (foodLine[0] == "Vegetable") food = new Vegetable(int.Parse(foodLine[1]));
                else food = new Meat(int.Parse(foodLine[1]));

                switch (line[0])
                {
                    case "Cat":
                        animal = new Cat(line[1], line[0], double.Parse(line[2]), line[3], line[4]);
                        break;
                    case "Tiger":
                        animal = new Tiger(line[1], line[0], double.Parse(line[2]), line[3]);
                        break;
                    case "Zebra":
                        animal = new Zebra(line[1], line[0], double.Parse(line[2]), line[3]);
                        break;
                    default:
                        animal = new Mouse(line[1], line[0], double.Parse(line[2]), line[3]);
                        break;
                }

                animal.makeSound();
                animal.eatFood(food);
                Console.WriteLine(animal);

                line = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
