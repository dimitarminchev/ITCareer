/// <summary>
/// Machine of type Car
/// </summary>
public class Car : IMachine
{
    public string MachineType { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public Car()
    {
        this.MachineType = "Car";
    }

    /// <summary>
    /// Start the machine
    /// </summary>
    public bool Start()
    {
        Console.WriteLine("Car Starting ...");
        return true;
    }

    /// <summary>
    /// Stop the machine
    /// </summary>
    public bool Stop()
    {
        Console.WriteLine("Car Stopping ...");
        return true;
    }
}