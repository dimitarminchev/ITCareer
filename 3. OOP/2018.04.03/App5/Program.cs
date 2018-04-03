using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    class Program
    {
        // Главна функция
        static void Main(string[] args)
        {
            Family family = new Family();
            // Входни данни
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                var line = Console.ReadLine().Split();
                family.AddMember(new Person()
                {
                    Name = line[0],
                    Age = int.Parse(line[1])
                });
                n--;
            }
            // Намиране на най-възрастния
            var oldest = family.GetOldestMember();
            Console.WriteLine("Oldest: {0} {1}", oldest.Name, oldest.Age);
        }
    }
}
