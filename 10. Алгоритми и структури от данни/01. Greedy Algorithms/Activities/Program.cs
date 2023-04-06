namespace Activities
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

    public class Activity
    {
        public string Name { get; set; }
        public int Start { get; set; }
        public int End { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();

            string[] input = Console.ReadLine().Split();
            while (input[0] != "END")
            {
                activities.Add(new Activity()
                {
                    Name = input[0],
                    Start = int.Parse(input[1]),
                    End = int.Parse(input[2])
                });
                input = Console.ReadLine().Split();
            }

            var queueActivities = new Queue<Activity>();

            var sortedActivities = activities.OrderBy(x => x.End);
            var selectedActivity = sortedActivities.First();
            queueActivities.Enqueue(selectedActivity);

            foreach (var currentActivity in sortedActivities)
            {
                if (currentActivity.Start >= selectedActivity.End)
                {
                    queueActivities.Enqueue(currentActivity);
                    selectedActivity = currentActivity;
                }
            }

            Console.Write("Solution: ");
            Console.WriteLine(string.Join(", ", queueActivities));
        }
    }
}