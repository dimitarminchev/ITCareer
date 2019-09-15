using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_TaskForce
{
    abstract class Employee
    {
        string name;
        int workHours;

        public Employee(string n)
        {
            name = n;
        }

        public int WorkHours
        {
            get { return workHours; }
            set { workHours = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
