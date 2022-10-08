namespace _04_TaskForce
{
    /// <summary>
    /// 1. Employee.cs
    /// 2. StandartEmployee.cs
    /// 3. PartTimeEmployee.cs
    /// 4. Job.cs
    /// 5. Program.cs
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            string[] input = System.Console.ReadLine().Split().ToArray();
            List<Employee> employees = new List<Employee>();
            List<Job> jobs = new List<Job>();

            while (input[0] != "End")
            {
                switch (input[0])
                {
                    case "StandartEmployee":
                        employees.Add(new StandartEmployee(input[1]));
                        break;
                    case "PartTimeEmployee":
                        employees.Add(new PartTimeEmployee(input[1]));
                        break;
                    case "Job":
                        jobs.Add(new Job
                        (
                            input[1], // Job Name
                            employees.FirstOrDefault(n => n.Name == input[3]), // Employee 
                            int.Parse(input[2])) // Hours
                        );
                        break;
                    case "Pass":
                        jobs.ForEach(x => x.Update());
                        break;
                    case "Status":
                        jobs.ForEach(x => Console.WriteLine(x.ToString()));
                        break;
                }
                input = System.Console.ReadLine().Split().ToArray();
            }
        }
    }
}