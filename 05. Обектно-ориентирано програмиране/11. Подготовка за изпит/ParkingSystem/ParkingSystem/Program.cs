using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        ParkingController controller = new ParkingController();
        StringBuilder stringBuilder = new StringBuilder();
        bool isRunning = true;

        while (isRunning)
        {
            List<string> lineArgs = Console.ReadLine().Split(":").ToList();
            string command = lineArgs[0];
            lineArgs = lineArgs.Skip(1).ToList();
            try
            {
                switch (command)
                {
                    case "CreateParkingSpot":
                        stringBuilder.AppendLine(controller.CreateParkingSpot(lineArgs));
                        break;
                    case "ParkVehicle":
                        stringBuilder.AppendLine(controller.ParkVehicle(lineArgs));
                        break;
                    case "FreeParkingSpot":
                        stringBuilder.AppendLine(controller.FreeParkingSpot(lineArgs));
                        break;
                    case "GetParkingSpotById":
                        stringBuilder.AppendLine(controller.GetParkingSpotById(lineArgs));
                        break;
                    case "GetParkingIntervalsByParkingSpotIdAndRegistrationPlate":
                        stringBuilder.AppendLine(controller.GetParkingIntervalsByParkingSpotIdAndRegistrationPlate(lineArgs));
                        break;
                    case "CalculateTotal":
                        stringBuilder.AppendLine(controller.CalculateTotal(lineArgs));
                        break;
                    case "End":
                        isRunning = false;
                        break;
                }
            }
            catch (ArgumentException ex)
            {
                stringBuilder.AppendLine(ex.Message);
            }
        }
        Console.WriteLine(stringBuilder.ToString().Trim());
    }
}