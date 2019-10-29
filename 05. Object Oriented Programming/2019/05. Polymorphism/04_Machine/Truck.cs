using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Machine
{
    // Truck
    public class Truck : IMachine
    {
        public string MachineType { get; set; }
        public Truck()
        {
            this.MachineType = "Truck";
        }
        public bool Start()
        {
            Console.WriteLine("Truck starting...");
            return true;
        }
        public bool Stop()
        {
            Console.WriteLine("Truck stopping...");
            return true;
        }
    }
}
