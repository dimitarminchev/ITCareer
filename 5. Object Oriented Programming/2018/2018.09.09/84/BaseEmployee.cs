using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _84
{
    public abstract class BaseEmployee
    {
        public string Name { get; private set; }
        public int WorkingHours { get; private set; }

        public BaseEmployee(string name, int workingHours)
        {
            this.Name = name;
            this.WorkingHours = workingHours;
        }
    }
}
