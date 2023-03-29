using System;
using System.Collections.Generic;
using System.Text;

internal class SubscriptionParkingSpot : ParkingSpot
{
    private string registrationPlate;
    public string RegistrationPlate
    {
        get { return registrationPlate; } 
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Registration plate can't be null or empty!");
            }
            registrationPlate = value;
        }
    }

    public SubscriptionParkingSpot(int id, bool occupied, double price, string registrationPlate) : base(id, occupied, "subscription", price)
    {
        RegistrationPlate = registrationPlate;
    }

    public override bool ParkVehicle(string registrationPlate, int hoursParked, string type)
    {
        // TODO: Implement ParkVehicle
        return base.ParkVehicle(registrationPlate, hoursParked, type);
    }

    public override double CalculateTotal()
    {
        // TODO: Implement CalculateTotal
        return base.CalculateTotal();
    }
}

