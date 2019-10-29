using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Machine
{
    // Airplane
    public class Airplane : IMachine
    {
        public string MachineType { get; set; }
        public Airplane()
        {
            this.MachineType = "Airplane";
        }
        public bool Start()
        {
            Console.WriteLine("Airplane starting...");
            return true;
        }
        public bool Stop()
        {
            Console.WriteLine("Airplane stopping...");
            return true;
        }
    }
}
