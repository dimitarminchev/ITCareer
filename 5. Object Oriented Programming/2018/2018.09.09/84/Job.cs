using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _84
{
    public class Job
    {

        public event JobDoneEventHandler JobIsDone;

        public string Name { get; private set; }
        public int HoursRequired { get; private set; }
        public BaseEmployee Employee { get; private set; }
        public Job(string name, int hoursRequired, BaseEmployee employee)
        {
            this.Name = name;
            this.HoursRequired = hoursRequired;
            this.Employee = employee;
        }

        public void Update()
        {
            this.HoursRequired -= Employee.WorkingHours;
            if (this.HoursRequired <= 0)
                if(JobIsDone!=null)
                    JobIsDone(this, new JobEventArgs(this));
        }

        public void OnJobDone(object sender, JobEventArgs e)
        {
            Helper.WriteLine($"Job {this.Name} done!");
        }
        public override string ToString()
        {
            return $"Job: {this.Name} Hours Remaining: {HoursRequired}";
        }
    }
}
