using System.IO;
using System.Xml.Linq;

namespace Jobs
{
    /// <summary>
    /// Програма
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            // Структура за данни
            List<Job> jobs = new List<Job>();

            // Входни данни: Input.txt
            using (StreamReader input = new StreamReader("Input.txt"))
            {
                int n = int.Parse(input.ReadLine());
                System.Console.WriteLine(n);

                for (int i = 0; i < n; i++)
                {
                    // 0 = Name, 1 = Deadline, 2 = Profit
                    string line = input.ReadLine(); 
                    System.Console.WriteLine(line);

                    string[] array = line.Split().ToArray();
                    jobs.Add(new Job
                    {
                        Id = int.Parse(array[0]),
                        Deadline = int.Parse(array[1]),
                        Profit = int.Parse(array[2])
                    });
                }
            }

            // Сортиране на дейностите
            List<Job> sortedJobs = jobs.OrderByDescending(job => job.Profit).ThenBy(job => job.Id).ToList();
            Job selected = sortedJobs.First();

            // ИЗбрани дейности
            Queue<Job> selectedJobs = new Queue<Job>();
            selectedJobs.Enqueue(selected);

            // Обработка
            foreach (var job in sortedJobs)
            {
                if (job.Deadline > selected.Deadline)
                {
                    selectedJobs.Enqueue(job);
                    selected = job;
                }
            }

            // Отговор
            Console.WriteLine(string.Join(" ", selectedJobs)); // Selected Jobs
            Console.WriteLine(selectedJobs.Sum(x => x.Profit)); // Maximum Profit
        }
    }
}