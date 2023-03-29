namespace TaskForce
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
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
                        jobs.Add(new Job(employees.FirstOrDefault(n => n.Name == input[3]), input[1], int.Parse(input[2])));
                        break;
                    case "Pass":
                        jobs.ForEach(x => x.Update());
                        break;
                    case "Status":
                        jobs.ForEach(x => Console.WriteLine(x.ToString()));
                        break;
                }
                input = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
