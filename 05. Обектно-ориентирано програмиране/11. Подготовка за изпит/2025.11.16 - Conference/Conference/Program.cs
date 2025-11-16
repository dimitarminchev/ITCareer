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
                    case "AddEventOffer":
                        result = controller.AddEventOffer(arguments);
                        break;
                    case "GetAverageTicketPrice":
                        result = controller.GetAverageTicketPrice(arguments);
                        break;
                    case "GetOffersAboveDuration":
                        result = controller.GetOffersAboveDuration(arguments);
                        break;
                    case "GetOffersWithTicketPrice":
                        result = controller.GetOffersWithTicketPrice(arguments);
                        break;
                    case "End":
                        isRunning = false;
                        break;
                    default:
                        result = "Invalid command";
                        break;
                }
                
                if(!isRunning) { break; }
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
