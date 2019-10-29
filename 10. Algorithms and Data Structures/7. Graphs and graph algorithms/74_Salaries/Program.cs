using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74_Salaries
{
    class Program
    {
        public class Employee
        {
            public int Salary;
            public List<int> Employees;

            public Employee()
            {
                this.Salary = 0;
                this.Employees = new List<int>();
            }
        }

        static List<Employee> employees;

        static void Main(string[] args)
        {
            employees = new List<Employee>();
            List<Employee> managers = new List<Employee>();

            int n = int.Parse(Console.ReadLine());

            string[] input = new string[n];
            for (int i = 0; i < n; i++)
            {
                input[i] = Console.ReadLine();
                employees.Add(new Employee());
                for (int j = 0; j < n; j++)
                {
                    if (input[i][j] == 'Y')
                    {
                        employees[i].Employees.Add(j);
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                bool isManaged = false;
                for (int j = 0; j < n; j++)
                {
                    if (input[j][i] == 'Y')
                    {
                        isManaged = true;
                        break;
                    }
                }
                if (!isManaged)
                {
                    managers.Add(employees[i]);
                }
            }

            employees.ForEach(x => x.Salary = x.Employees.Count == 0 ? 1 : 0);
            foreach (var manager in managers)
            {
                FindTotalSalary(manager);
            }
            Console.WriteLine(employees.Sum(x => x.Salary));
        }

        static int FindTotalSalary(Employee currentEmployee)
        {
            if (currentEmployee.Salary == 0)
            {
                int total = 0;
                foreach (var managedEmployee in currentEmployee.Employees)
                {
                    total += FindTotalSalary(employees[managedEmployee]);
                }
                currentEmployee.Salary = total;
            }
            return currentEmployee.Salary;
        }
    }
}
