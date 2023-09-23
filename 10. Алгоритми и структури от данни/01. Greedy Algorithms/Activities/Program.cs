namespace Activities
{
    /// <summary>
    /// Програма
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            // Структура за данни 
            List<Activity> activities = new List<Activity>();

            // Входни данни: Input.txt
            using (StreamReader input = new StreamReader("Input.txt"))
            {
                string line = input.ReadLine();
                System.Console.WriteLine(line);

                while (line != "END")
                {
                    // 0 = name, 1 = start, 2 = end
                    string[] array = line.Split().ToArray(); 

                    activities.Add(new Activity
                    {
                        Name = array[0],
                        Start = int.Parse(array[1]),
                        End = int.Parse(array[2])
                    });

                    line = input.ReadLine();
                    System.Console.WriteLine(line);
                }
            }

            // Сортиране
            List<Activity> sortedActivities = activities.OrderBy(x => x.End).ToList<Activity>();

            // Избрана дейност
            Activity selectedActivity = sortedActivities.First();

            // Дейности
            Queue<Activity> queueActivities = new Queue<Activity>();
            queueActivities.Enqueue(selectedActivity);

            // Обработка
            foreach (var currentActivity in sortedActivities)
            {
                if (currentActivity.Start >= selectedActivity.End)
                {
                    queueActivities.Enqueue(currentActivity);
                    selectedActivity = currentActivity;
                }
            }

            // Отговор
            Console.WriteLine(string.Join("\n", queueActivities));

        }
    }
}