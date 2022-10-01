/// <summary>
/// Превозно средство: Автобус
/// </summary>
public class Bus : IVehicle
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
    ///  Капацитет за гориво
    /// </summary>
    public double FuelCapacity
    {
        get { return fuelCapacity; }
        set { fuelCapacity = value; }
    }
    private double fuelCapacity;

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
    /// Пътници [да|не]
    /// </summary>
    public bool Passangers { get; set; }

    /// <summary>
    /// Конструктор
    /// </summary>
    public Bus(double fuel, double liters, double capacity)
    {
        Fuel = fuel;
        LitersPerKm = liters;
        FuelCapacity = capacity;
        Distance = 0;
        Passangers = false;
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
            Console.WriteLine("Bus traveled " + km + " km");
            Distance += km;
        }
        else
        {
            Console.WriteLine("Bus needs refueling");
        }
    }

    /// <summary>
    /// Презареди
    /// </summary>
    public void Refuel(double litres)
    {
        if (litres < 0 || litres > fuelCapacity)
        {
            Console.WriteLine("Cannot fit fuel in tank");
        }
        else Fuel += litres; 
    }
}