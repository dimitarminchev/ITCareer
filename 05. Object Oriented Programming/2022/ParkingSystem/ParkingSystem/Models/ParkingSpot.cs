using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

public abstract class ParkingSpot
{
    private int id;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    private bool occupied;

    public bool Occupied
    {
        get { return occupied; }
        set { occupied = value; }
    }

    private string type;

    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    private double price;

    public double Price
    {
        get { return price; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Parking price cannot be less or equal to 0!");
            }
            price = value;
        }
    }

    protected List<ParkingInterval> parkingIntervals;

    public ParkingSpot(int id, bool occupied, string type, double price)
    {
        Id = id;
        Occupied = occupied;
        Type = type;
        Price = price;
        parkingIntervals = new List<ParkingInterval>();
    }

    public virtual bool ParkVehicle(string registrationPlate, int hoursParked, string type)
    {
        if (!this.Occupied && this.Type == type)
        {
            var parkingInterval = new ParkingInterval(this, registrationPlate, hoursParked);
            this.parkingIntervals.Add(parkingInterval);
            this.Occupied = true;
            return true;
        }
        return false;
    }

    public List<ParkingInterval> GetAllParkingIntervalsByRegistrationPlate(string registrationPlate)
    {
        return parkingIntervals.Where(x => x.RegistrationPlate == registrationPlate).ToList();
    }

    public virtual double CalculateTotal()
    {
        return parkingIntervals.Sum(x => x.Revenue);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"> Parking Spot #{id}");
        sb.AppendLine($"> Occupied: {occupied}");
        sb.AppendLine($"> Type: {type}");
        sb.AppendLine($"> Price per hour: {string.Format("{0:F2}", price)} BGN");

        return sb.ToString().TrimEnd();
    }

}
