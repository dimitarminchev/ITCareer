using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Machine
{
    // LawnMower
    public class LawnMower : IMachine
    {
        public string MachineType { get; set; }
        public LawnMower()
        {
            this.MachineType = "LawnMower";
        }
        public bool Start()
        {
            Console.WriteLine("LawnMower starting...");
            return true;
        }
        public bool Stop()
        {
            Console.WriteLine("LawnMower stopping...");
            return true;
        }
    }
}
