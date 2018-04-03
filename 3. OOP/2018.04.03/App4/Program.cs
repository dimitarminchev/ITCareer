using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    class Program
    {
        // Главен метод 
        static void Main(string[] args)
        {
            // Входни данни
            List<Employee> company = new List<Employee>();
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                var line = Console.ReadLine().Split();
                switch (line.Count())
                {
                    case 4:
                    {
                        company.Add(new Employee()
                        {
                             Name = line[0],
                             Salary = double.Parse(line[1]),
                             Job = line[2],
                             Department = line[3],
                             Email = "n/a",
                             Age = -1
                        });
                        break;
                    }
                    case 5:
                    {
                            int val;
                            if (int.TryParse(line[4], out val))
                                company.Add(new Employee()
                                {
                                    Name = line[0],
                                    Salary = double.Parse(line[1]),
                                    Job = line[2],
                                    Department = line[3],
                                    Email = "n/a",
                                    Age = val
                                });
                            else
                                company.Add(new Employee()
                                {
                                    Name = line[0],
                                    Salary = double.Parse(line[1]),
                                    Job = line[2],
                                    Department = line[3],
                                    Email = line[4],
                                    Age = -1
                                });
                            break;
                        }
                    case 6:
                    {
                            company.Add(new Employee()
                            {
                                Name = line[0],
                                Salary = double.Parse(line[1]),
                                Job = line[2],
                                Department = line[3],
                                Email = line[4],
                                Age = int.Parse(line[5])
                            });
                            break;
                        }
                }
                n--;
            }

            // Намиране на сума на заплатите по отдели
            var temp = company.GroupBy(a => a.Department).ToDictionary
            (
                  key => key.First().Department,
                  value => value.Average(b => b.Salary)
            ).OrderByDescending(c => c.Value);

            // Извеждаме отдела с най-висока средна заплата
            Console.WriteLine("Highest Average Salary: {0}", temp.First().Key);

            // Служителите в този отдел
            var names = company.Where(a => a.Department == temp.First().Key).OrderByDescending(b => b.Salary);
            foreach (var item in names)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}",
                item.Name, item.Salary, item.Job, item.Department, item.Email, item.Age);
            }

        }
    }
}
