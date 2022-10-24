using System;
using System.Collections.Generic;
using System.Text;

public class CarParkingSpot : ParkingSpot
{
    public CarParkingSpot(int id, bool occupied, double price) : 
           base(id, occupied, "car", price)
    {
        // TODO: Implement me
    }
}
