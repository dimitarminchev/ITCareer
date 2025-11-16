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

    public string CreateParkingSpot(List<string> args)
    {
        int id = int.Parse(args[0]);
        bool occupied = bool.Parse(args[1]);
        string type = args[2];
        double price = double.Parse(args[3]);

        if (parkingSpots.Any(x => x.Id == id))
        {
            return $"Parking spot {id} is already registered!";
        }
        if (type == "car")
        {
            CarParkingSpot parkingSpot = new CarParkingSpot(id, occupied, price);
            parkingSpots.Add(parkingSpot);
            return $"Parking spot {id} was successfully registered in the system!";
        }
        else if (type == "bus")
        {
            BusParkingSpot parkingSpot = new BusParkingSpot(id, occupied, price);
            parkingSpots.Add(parkingSpot);
            return $"Parking spot {id} was successfully registered in the system!";
        }
        else if (type == "subscription")
        {
            string registrationPlate = args[4];
            SubscriptionParkingSpot parkingSpot = new SubscriptionParkingSpot(id, occupied, price, registrationPlate);
            parkingSpots.Add(parkingSpot);
            return $"Parking spot {id} was successfully registered in the system!";
        }
        return "Unable to create parking spot!";
    }

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

    public string FreeParkingSpot(List<string> args)
    {
        int parkingSpotId = int.Parse(args[0]);

        ParkingSpot spot = parkingSpots.FirstOrDefault(x => x.Id == parkingSpotId);
        
        if (spot == null)
        {
            return $"Parking spot {parkingSpotId} not found!";
        }
        if (!spot.Occupied)
        {
            return $"Parking spot {parkingSpotId} is not occupied.";
        }

        parkingSpots.First(x => x.Id == parkingSpotId).Occupied = false;

        return $"Parking spot {parkingSpotId} is now free!";
    }

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

    public string CalculateTotal(List<string> args)
    {
        double sum = parkingSpots.Sum(x => x.CalculateTotal());

        return $"Total revenue from the parking: {sum:F2} BGN";
    }

}