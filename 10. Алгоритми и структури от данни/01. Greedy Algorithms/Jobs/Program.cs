namespace Jobs
{
    public static class Console
    {
        public static void WriteLine<T>(T output)
        {
            var originalColor = System.Console.ForegroundColor;
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(output);
            System.Console.ForegroundColor = originalColor;
        }

        public static void Write<T>(T output)
        {
            var originalColor = System.Console.ForegroundColor;
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.Write(output);
            System.Console.ForegroundColor = originalColor;
        }

        public static string ReadLine() => System.Console.ReadLine();
    }

    public class Job
    {
        public int Id { get; set; }

        public int Deadline { get; set; }

        public float Price { get; set; }

        public override string ToString()
        {
            return string.Format("j{0}", Id);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            List<Job> Jobs = new List<Job>();
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                string[] input = Console.ReadLine().Split();
                Jobs.Add(new Job()
                {
                    Id = int.Parse(input[0]),
                    Deadline = int.Parse(input[1]),
                    Price = float.Parse(input[2])
                });
                n--;
            }

            Queue<Job> selectedJobs = new Queue<Job>();
            var sorted = Jobs.OrderByDescending(x => x.Price);
            var selected = sorted.First();
            selectedJobs.Enqueue(selected);
            foreach (var job in sorted)
            {
                if (job.Deadline > selected.Deadline)
                {
                    selectedJobs.Enqueue(job);
                    selected = job;
                }
            }

            Console.Write("Solution: ");
            Console.WriteLine(string.Join(", ", selectedJobs));
            Console.Write("Sum: ");
            Console.WriteLine(selectedJobs.Sum(x => x.Price));
        }
    }
}