using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        Controller controller = new Controller();
        bool isRunning = true;

        while (isRunning)
        {
            string[] splittedInput = Console.ReadLine().Split();

            string command = splittedInput[0];
            List<string> arguments = splittedInput
                .Skip(1)
                .ToList();

            string result = "";
            try
            {
                switch (command)
                {
                    case "AddCategory":
                        result = controller.AddCategory(arguments);
                        break;
                    case "AddProductToCategory":
                        result = controller.AddProductToCategory(arguments);
                        break;
                    case "GetMinPrice":
                        result = controller.GetMinPrice(arguments);
                        break;
                    case "GetProductsInRange":
                        result = controller.GetProductsInRange(arguments);
                        break;
                    case "GetProductsExpensiveToCheap":
                        result = controller.GetProductsExpensiveToCheap(arguments);
                        break;
                    case "GetProductsCheapToExpensive":
                        result = controller.GetProductsCheapToExpensive(arguments);
                        break;
                    case "End":
                        isRunning = false;
                        break;
                    default:
                        result = "Invalid command";
                        break;
                }

                if (!isRunning) { break; }
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }
    }
}
