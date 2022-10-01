public class MachineOperator
{
    /// <summary>
    /// Machine
    /// </summary>
    private IMachine machine;
    public IMachine Machine 
    { 
        get 
        {
            return machine;
        }
        set 
        {
            if (value == null)
            {
                throw new ArgumentNullException("Machine can not be null!");
            }
            machine = value;
            Console.WriteLine("Machine operator is operationg: " + value.MachineType);
        }
    }

    /// <summary>
    /// Constructor
    /// </summary>
    public MachineOperator(IMachine machine)
    {
        Machine = machine;
    }
}