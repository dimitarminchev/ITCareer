/// <summary>
/// Interface
/// </summary>
public interface IMachine
{
    /// <summary>
    /// The type of the machine
    /// </summary>
    string MachineType { get; set; }

    /// <summary>
    /// Start the machine
    /// </summary>
    bool Start();

    /// <summary>
    /// Stop the machine
    /// </summary>
    bool Stop();
}