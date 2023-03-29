using System;
using System.Collections.Generic;
using System.Text;

public class ParkingInterval
{
    private ParkingSpot parkingSpot;

    public ParkingSpot ParkingSpot
    {
        get { return parkingSpot; }
        set { parkingSpot = value; }
    }

    private string registrationPlate;

    public string RegistrationPlate
    {
        get
        {
            return registrationPlate;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Registration plate can't be null or empty!");
            }
            registrationPlate = value;
        }
    }

    private int hoursParked;

    public int HoursParked  
    {
        get
        {
            return hoursParked;
        }
        
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Hours parked can't be zero or negative!");
            }
            hoursParked = value;
        }
    }

    public double Revenue
    {
        get 
        {
            if (parkingSpot.Type == "subscription")
            {
                return 0;
            }
            return parkingSpot.Price * hoursParked;
        }
    }

    public ParkingInterval(ParkingSpot parkingSpot, string registrationPlate, int hoursParked)
    {
        ParkingSpot = parkingSpot;
        RegistrationPlate = registrationPlate;
        HoursParked = hoursParked;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"> Parking Spot #{parkingSpot.Id}");
        sb.AppendLine($"> RegistrationPlate: {registrationPlate}");
        sb.AppendLine($"> HoursParked: {hoursParked}");
        sb.AppendLine($"> Revenue: {string.Format("{0:F2}", Revenue)} BGN");

        return sb.ToString().TrimEnd();
    }
}