using System;
using System.Collections.Generic;
using System.Text;

public class BusParkingSpot : ParkingSpot
{
    public BusParkingSpot(int id, bool occupied, double price) : 
        base(id, occupied, "bus", price)
    {
        // TODO: Implement me
    }
}
