using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Machine
{
    // Car
    public class Car : IMachine
    {
        public string MachineType { get; set; }
        public Car()
        {
            this.MachineType = "Car";
        }
        public bool Start()
        {
            Console.WriteLine("Car starting...");
            return true;
        }
        public bool Stop()
        {
            Console.WriteLine("Car stopping...");
            return true;
        }

    }
}
