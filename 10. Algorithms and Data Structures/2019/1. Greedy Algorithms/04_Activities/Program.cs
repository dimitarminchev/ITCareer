using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Activities
{
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

    class Program
    {
        // Задача за възлагане на дейности
        static void Main(string[] args)
        {
            List<Activity> activities = new List<Activity>();
/* Input
a1 1 3
a2 0 4
a3 1 2
a4 4 6
a5 2 9
a6 5 8
a7 3 5
a8 4 5
END
*/
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

            // ResultSet
            var queueActivities = new Queue<Activity>();

            // Process
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

            // Print
            Console.Write("Probable Solution: ");
            Console.WriteLine(string.Join(", ",queueActivities));
        }
    }
}
