/// <summary>
/// Превозно средство: Камион
/// </summary>
public class Truck : IVehicle
{
    /// <summary>
    /// Гориво
    /// </summary>
    public double Fuel
    {
        get { return fuel; }
        set { fuel = value; }
    }
    private double fuel;

    /// <summary>
    /// Литри на километър
    /// </summary>
    public double LitersPerKm
    {
        get { return litersperkm; }
        set { litersperkm = value; }
    }
    private double litersperkm;

    /// <summary>
    /// Разстояние
    /// </summary>
    public double Distance
    {
        get { return distance; }
        set { distance = value; }
    }
    private double distance;

    /// <summary>
    /// Конструктор
    /// </summary>
    public Truck(double fuel, double litersPerKm)
    {
        Fuel = fuel; 
        LitersPerKm = litersPerKm + 1.6;
        Distance = 0;
    }

    /// <summary>
    /// Карай
    /// </summary>
    public void Drive(double km)
    {
        var travel = litersperkm * km;
        if (travel <= fuel)
        {
            Fuel -= travel;
            Console.WriteLine("Truck traveled " + km + " km");
            Distance += km;
        }
        else
        {
            Console.WriteLine("Truck needs refueling.");
        }
    }

    /// <summary>
    /// Презареди
    /// </summary>
    public void Refuel(double litres)
    {
        Fuel += (litres * 0.95); // 95% 
    }
}