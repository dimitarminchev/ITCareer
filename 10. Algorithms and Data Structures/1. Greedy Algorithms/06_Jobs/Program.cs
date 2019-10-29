using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Jobs
{

    public class Job
    {
        public int Id { get; set; }

        public int Deadline { get; set; }

        public float Price { get; set; }

        public override string ToString()
        {
            return string.Format("j{0}",Id);
        }
    }

    class Program
    {
        // Задача за подреждане на работа в срок
        static void Main(string[] args)
        {
            List<Job> Jobs = new List<Job>();
/* Input
5     
1 2 60
2 1 100
3 3 20
4 2 40
5 1 20
*/
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

            // Process
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

            // Print
            Console.Write("Probable Solution: ");
            Console.WriteLine(string.Join(", ", selectedJobs));
            Console.WriteLine("Sum = {0}", selectedJobs.Sum(x => x.Price));

        }
    }
}
