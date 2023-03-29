using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ParkingController
{
    private List<ParkingSpot> parkingSpots;

    public ParkingController()
    {
        parkingSpots = new List<ParkingSpot>();
    }

    /// <summary>
    /// CreateParkingSpot
    /// </summary>
    /// <param name="args">
    /// {parkingSpotId}:{occupied}:{type}:{price}
    /// </param>
    public string CreateParkingSpot(List<string> args)
    {
        int parkingSpotId = int.Parse(args[0]);
        bool occupied = bool.Parse(args[1]);
        string type = args[2];
        double price = double.Parse(args[3]);

        if (parkingSpots.Any(x => x.Id == parkingSpotId))
        {
            return $"Parking spot {parkingSpotId} is already registered!";
        }
        if (type == "car")
        {
            CarParkingSpot parkingSpot = new CarParkingSpot(parkingSpotId, occupied, price);
            parkingSpots.Add(parkingSpot);
            return $"Parking spot {parkingSpotId} was successfully registered in the system!";
        }
        else if (type == "bus")
        {
            BusParkingSpot parkingSpot = new BusParkingSpot(parkingSpotId, occupied, price);
            parkingSpots.Add(parkingSpot);
            return $"Parking spot {parkingSpotId} was successfully registered in the system!";
        }
        else if (type == "subscription")
        {
            string registrationPlate = args[4];
            SubscriptionParkingSpot parkingSpot = new SubscriptionParkingSpot(parkingSpotId, occupied, price, registrationPlate);
            parkingSpots.Add(parkingSpot);
            return $"Parking spot {parkingSpotId} was successfully registered in the system!";
        }
        return "Unable to create parking spot!";
    }

    /// <summary>
    /// ParkVehicle
    /// </summary>
    /// <param name="args">
    /// {parkingSpotId}:{registrationPlate}:{hoursParked}:{type}
    /// </param>
    public string ParkVehicle(List<string> args)
    {
        int parkingSpotId = int.Parse(args[0]);
        string registrationPlate = args[1];
        int hoursParked = int.Parse(args[2]);
        string type = args[3];

        if (!parkingSpots.Any(x => x.Id == parkingSpotId))
        {
            return $"Parking spot {parkingSpotId} not found!";
        }
        if (parkingSpots[parkingSpotId - 1].Type != type || parkingSpots[parkingSpotId - 1].Occupied == true)
        {
            return $"Vehicle {registrationPlate} can't park at {parkingSpotId}";
        }
        parkingSpots[parkingSpotId - 1].ParkVehicle(registrationPlate, hoursParked, type);

        return $"Vehicle {registrationPlate} parked at {parkingSpotId} for {hoursParked} hours.";
    }

    /// <summary>
    /// FreeParkingSpot:
    /// </summary>
    /// <param name="args">
    /// {parkingSpotId}
    /// </param>
    public string FreeParkingSpot(List<string> args)
    {
        int parkingSpotId = int.Parse(args[0]);

        ParkingSpot spot = parkingSpots.FirstOrDefault(x => x.Id == int.Parse(args[0]));
        if (spot == null)
        {
            return $"Parking spot {parkingSpotId} not found!";
        }
        if (!spot.Occupied) 
        {
            return $"Parking spot {parkingSpotId} is not occupied.";
        }

        spot.Occupied = false;

        return $"Parking spot {parkingSpotId} is now free!";
    }

    /// <summary>
    /// GetParkingSpotById:
    /// </summary>
    /// <param name="args">
    /// {parkingSpotId}
    /// </param>
    public string GetParkingSpotById(List<string> args)
    {
        int parkingSpotId = int.Parse(args[0]);

        ParkingSpot spot = parkingSpots.FirstOrDefault(x => x.Id == int.Parse(args[0]));
        if (spot == null)
        {
            return $"Parking spot {parkingSpotId} not found!";
        }

        return spot.ToString();
    }

    /// <summary>
    /// GetParkingIntervalsByParkingSpotIdAndRegistrationPlate
    /// </summary>
    /// <param name="args">
    /// {parkingSpotId}:{registrationPlate}
    /// </param>
    public string GetParkingIntervalsByParkingSpotIdAndRegistrationPlate(List<string> args)
    {
        int parkingSpotId = int.Parse(args[0]);
        string registrationPlate = args[1];

        ParkingSpot spot = parkingSpots.FirstOrDefault(x => x.Id == int.Parse(args[0]));
        if (spot == null)
        {
            return $"Parking spot {parkingSpotId} not found!";
        }

        var parkingIntervals = spot.GetAllParkingIntervalsByRegistrationPlate(registrationPlate);

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"Parking intervals for parking spot {parkingSpotId}:");
        foreach (var parkingInterval in parkingIntervals)
        {
            stringBuilder.AppendLine(parkingInterval.ToString());
        }
        return stringBuilder.ToString().TrimEnd();
    }

    /// <summary>
    /// CalculateTotal
    /// </summary>
    public string CalculateTotal(List<string> args)
    {
        double sum = parkingSpots.Sum(x => x.CalculateTotal());

        return $"Total revenue from the parking: {sum:F2} BGN";
    }

}

