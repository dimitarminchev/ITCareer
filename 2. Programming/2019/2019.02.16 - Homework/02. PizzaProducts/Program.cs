using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PizzaProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pizzaIngredients = Console.ReadLine().Split(' ').ToArray();
            int productNameLenght = int.Parse(Console.ReadLine());
            string needeIngredients = "";
            int counter = 0;
            for (int i = 0; i < pizzaIngredients.Length; i++)
            {
                if (pizzaIngredients[i].Length == productNameLenght)
                {
                    Console.WriteLine($"Adding {pizzaIngredients[i]}");
                    needeIngredients += pizzaIngredients[i] + " ";
                    counter++;
                    if (counter > 9) break;
                }
            }
            Console.WriteLine($"Made pizza with total of {counter} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", needeIngredients.Split(' ').ToArray())}.");
        }
    }
}
