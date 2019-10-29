using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Machine
{
    public class MachineOperator
    {
        // Type of the machine
        private IMachine machine;
        public IMachine Machine
        {
            get { return this.machine; }
            set
            {
                this.machine = value;
                Console.WriteLine("Machine operator is operating: " + value.MachineType);
            }
        }

        // Constructor
        public MachineOperator(IMachine entity)
        {
            this.Machine = entity;
        }

    }
}
