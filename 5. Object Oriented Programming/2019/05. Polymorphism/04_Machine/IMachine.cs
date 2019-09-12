using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Machine
{
    // Interface
    public interface IMachine
    {
        string MachineType { get; set; }
        bool Start();
        bool Stop();

    }
}
