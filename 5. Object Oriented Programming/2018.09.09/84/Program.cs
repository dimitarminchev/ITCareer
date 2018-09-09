using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _84
{
    public delegate void JobDoneEventHandler(object sender, JobEventArgs e);

    class Program
    {
        static void Main(string[] args)
        {
            List<BaseEmployee> employees = new List<BaseEmployee>();
            JobList jobs = new JobList();
            
            string[] command = Console.ReadLine().Split().ToArray();
            while(command[0]!="End")
            {
                switch (command[0])
                {
                    case "StandartEmployee":
                        employees.Add(new StandartEmpoyee(command[1]));
                        break;
                    case "PartTimeEmployee":
                        employees.Add(new PartTimeEmployee(command[1]));
                        break;
                    case "Job":
                        Job realJob = new Job(command[1], int.Parse(command[2]), employees.Where(x => x.Name == command[3]).First());
                        realJob.JobIsDone += realJob.OnJobDone;
                        realJob.JobIsDone += jobs.OnJobDone; 
                        jobs.Add(realJob);
                        break;
                    case "Status":
                        foreach (var job in jobs) Helper.WriteLine(job);
                        break;
                    case "Pass":
                        List<Job> jobsToUpdate = new List<Job>(jobs);
                        foreach (var job in jobsToUpdate)
                        {
                            job.Update();
                        }
                        break;
                    default:
                        Helper.WriteLine("Invalid command!");
                        break;
                }

                command = Console.ReadLine().Split().ToArray();
            }


        }
    }
}
