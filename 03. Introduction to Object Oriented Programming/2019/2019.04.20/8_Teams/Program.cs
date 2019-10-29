using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Teams
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object
            Team team = new Team("Arsenal");

            // Input
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                var line = Console.ReadLine().Split().ToArray();
                team.AddPlayer
                (
                    new Person
                    (
                        line[0], // First Name
                        line[1], // Last Name
                        int.Parse(line[2]), // Age
                        float.Parse(line[3]) // Salary
                    )
                );
                n--;
            }

            // Print
            Console.WriteLine(team);
        }
    }
}
