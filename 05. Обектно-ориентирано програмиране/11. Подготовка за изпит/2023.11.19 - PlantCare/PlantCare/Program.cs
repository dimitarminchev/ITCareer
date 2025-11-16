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
                    case "AddCareItem":
                        result = controller.AddCareItem(arguments);
                        break;
                    case "AddPlant":
                        result = controller.AddPlant(arguments);
                        break;
                    case "GetTotalCaresByPlantId":
                        result = controller.GetTotalCaresByPlantId(arguments);
                        break;
                    case "WaterPlantById":
                        result = controller.WaterPlantById(arguments);
                        break;
                    case "FertilizePlantById":
                        result = controller.FertilizePlantById(arguments);
                        break;
                    case "GetTallestTree":
                        result = controller.GetTallestTree(arguments);
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