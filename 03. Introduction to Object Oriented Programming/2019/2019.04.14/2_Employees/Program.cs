using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            // input
            int n = int.Parse(Console.ReadLine());
            while(n > 0)
            {
                var line = Console.ReadLine().Split().ToArray();

                // Prepare
                int age = -1;
                string email = "n/a";
                if (line.Count() == 6)
                {
                    email = line[4];
                    age = int.Parse(line[5]);
                }
                else if (line.Count() > 4)
                if (!int.TryParse(line[4], out age))
                {
                    age = -1;
                    if(!string.IsNullOrEmpty(line[4]))
                    email = line[4];
                }

                // Insert
                employees.Add
                (
                    new Employee()
                    {
                        // Required
                        Name = line[0],
                        Salary = double.Parse(line[1]),
                        Position = line[2],
                        Department = line[3],
                        // Optional
                        Email = email,
                        Age = age
                    }
                );

                n--;
            }

            // Processing
            Dictionary<string, List<double>> departmentsPartitioning = new Dictionary<string, List<double>>();
            foreach (var employee in employees)
            {
                if (!departmentsPartitioning.ContainsKey(employee.Department))
                {
                    departmentsPartitioning[employee.Department] = new List<double>();
                }
                departmentsPartitioning[employee.Department].Add(employee.Salary);
            }
            Dictionary<string, double> averageSalaryByDepartments = new Dictionary<string, double>();              
            foreach (var item in departmentsPartitioning.Keys)
            {
                averageSalaryByDepartments[item] = departmentsPartitioning[item].Average();
            }            
            var maxAverageSalaryDepartment = averageSalaryByDepartments.OrderByDescending(item => item.Value).First();
            Console.WriteLine("Highest Average Salary: {0}", maxAverageSalaryDepartment.Key);

            // Sort By Salary
            employees = employees.OrderByDescending(x => x.Salary).ToList();

            // Print this Shit!
            foreach (var employ in employees)
            {
                if (employ.Department == maxAverageSalaryDepartment.Key)
                {
                    Console.WriteLine($"{employ.Name} {employ.Salary} {employ.Email} {employ.Age}");
                }
            }
        }
    }
}
