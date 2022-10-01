/// <summary>
/// Machine of type Truck
/// </summary>
public class Truck : IMachine
{
    public string MachineType { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public Truck()
    {
        this.MachineType = "Truck";
    }

    /// <summary>
    /// Start the machine
    /// </summary>
    public bool Start()
    {
        Console.WriteLine("Truck Starting ...");
        return true;
    }

    /// <summary>
    /// Stop the machine
    /// </summary>
    public bool Stop()
    {
        Console.WriteLine("Truck Stopping ...");
        return true;
    }
}