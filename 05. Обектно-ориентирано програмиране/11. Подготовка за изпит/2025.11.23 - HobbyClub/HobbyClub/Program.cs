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
                    case "AddClub":
                        result = controller.AddClub(arguments);
                        break;
                    case "AddActivity":
                        result = controller.AddActivity(arguments);
                        break;
                    case "RateActivity":
                        result = controller.RateActivity(arguments);
                        break;
                    case "GetAverageRating":
                        result = controller.GetAverageRating(arguments);
                        break;
                    case "GetActivitiesByLeader":
                        result = controller.GetActivitiesByLeader(arguments);
                        break;
                    case "GetActivitiesBetweenDuration":
                        result = controller.GetActivitiesBetweenDuration(arguments);
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
