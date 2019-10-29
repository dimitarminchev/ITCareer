using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Machine
{
    class Program
    {
        // Task 4. Interfaces
        static void Main(string[] args)
        {
            Car car = new Car();
            LawnMower lawnMower = new LawnMower();
            Airplane airplane = new Airplane();
            Truck truck = new Truck();

            MachineOperator machineOperator = new MachineOperator(car);
            machineOperator.Machine.Start();
            machineOperator.Machine.Stop();

            machineOperator.Machine = lawnMower;
            machineOperator.Machine.Start();
            machineOperator.Machine.Stop();

            machineOperator.Machine = airplane;
            machineOperator.Machine.Start();
            machineOperator.Machine.Stop();

            machineOperator.Machine = truck;
            machineOperator.Machine.Start();
            machineOperator.Machine.Stop();
        }
    }
}
