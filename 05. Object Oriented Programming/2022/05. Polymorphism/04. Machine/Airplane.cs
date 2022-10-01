/// <summary>
/// Machine of type Truck
/// </summary>
public class Airplane : IMachine
{
    public string MachineType { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public Airplane()
    {
        this.MachineType = "Airplane";
    }

    /// <summary>
    /// Start the machine
    /// </summary>
    public bool Start()
    {
        Console.WriteLine("Airplane Starting ...");
        return true;
    }

    /// <summary>
    /// Stop the machine
    /// </summary>
    public bool Stop()
    {
        Console.WriteLine("Airplane Stopping ...");
        return true;
    }
}