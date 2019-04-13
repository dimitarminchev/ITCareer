using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Program
    {
        // Главен метод
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family semeistvo = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                semeistvo.AddMember
                (
                    new Person { Name = input[0], Age = int.Parse(input[1]) }
                );
            }
            semeistvo.Over30();
        }
    }
}
