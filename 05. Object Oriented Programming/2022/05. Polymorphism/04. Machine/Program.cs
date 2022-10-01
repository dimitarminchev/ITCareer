namespace _04._Machine
{
    public class Program
    {
        static void Main(string[] args)
        {
            MachineOperator peter = new MachineOperator(new Car());
            peter.Machine.Start();
            peter.Machine.Stop();

            peter.Machine = new Truck();
            peter.Machine.Start();
            peter.Machine.Stop();

            peter.Machine = new Airplane();
            peter.Machine.Start();
            peter.Machine.Stop();
        }
    }
}