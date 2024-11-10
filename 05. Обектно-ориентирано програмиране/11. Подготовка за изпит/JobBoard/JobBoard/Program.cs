using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
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
                    case "AddJobOffer":
                        result = controller.AddJobOffer(arguments);
                        break;
                    case "GetAverageSalary":
                        result = controller.GetAverageSalary(arguments);
                        break;
                    case "GetOffersAboveSalary":
                        result = controller.GetOffersAboveSalary(arguments);
                        break;
                    case "GetOffersWithoutSalary":
                        result = controller.GetOffersWithoutSalary(arguments);
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
                Console.WriteLine(e.Message);
            }
        }
    }
}