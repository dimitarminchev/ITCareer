using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_TaskForce
{
    class Job
    {
        public Job(Employee employee, string name, int hours)
        {
            baseEmployee = employee;
            this.name = name;
            hoursOfWorkRequired = hours;
        }

        Employee baseEmployee;
        string name;
        int hoursOfWorkRequired;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void Update()
        {


            hoursOfWorkRequired -= baseEmployee.WorkHours;

            if (hoursOfWorkRequired <= 0)
            {
                Console.WriteLine($"Job {name} done!");
            }
        }

        public override string ToString()
        {
            return $"Job: {name} Hours Remaining: {hoursOfWorkRequired}";
        }
    }
}
