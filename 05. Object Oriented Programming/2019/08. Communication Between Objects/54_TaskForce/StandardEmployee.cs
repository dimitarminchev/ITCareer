using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_TaskForce
{
    class StandartEmployee : Employee
    {
        int workHours = 40;

        public StandartEmployee(string name) : base(name) { base.WorkHours = 40; }
    }
}
