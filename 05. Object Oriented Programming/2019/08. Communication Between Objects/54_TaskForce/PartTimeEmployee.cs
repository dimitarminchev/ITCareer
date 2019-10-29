using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_TaskForce
{
    class PartTimeEmployee : Employee
    {
        public static int workHours;

        public PartTimeEmployee(string name) : base(name) { base.WorkHours = 20; }
    }
}
