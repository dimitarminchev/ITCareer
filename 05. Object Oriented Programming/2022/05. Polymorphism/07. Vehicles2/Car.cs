/// <summary>
/// Превозно средство: Автомобил
/// </summary>
public class Car : IVehicle
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
    /// Конструктор
    /// </summary>
    public Car(double fuel, double liters, double capacity)
    {
        Fuel = fuel; 
        LitersPerKm = liters + 0.9;
        FuelCapacity = capacity;
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
            Console.WriteLine("Car traveled " + km + " km");
            Distance += km;
        }
        else 
        {
            Console.WriteLine("Car needs refueling.");
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
        else Fuel += litres; // 100%
    }
}