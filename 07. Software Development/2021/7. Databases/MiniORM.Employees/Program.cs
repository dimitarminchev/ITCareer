using System;
using System.Linq;

namespace Employees
{
    // My database model
    using Employees.Model;
    using Employees.Model.Entities;

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Microsoft SQL Server Connection String
            string connString = "Server=(localdb)\\MSSQLLocalDB;Database=MiniORM;Integrated Security=true";

            // 2. MiniORM Database Context
            EmployeesDbContext dbContext = new EmployeesDbContext(connString);

            // 3. List Employeees Names
            Console.WriteLine("Employees:");
            Console.WriteLine(new string('-', 25));
            foreach (var employee in dbContext.Employees)
            {
                Console.WriteLine("{0} {1}", employee.FirstName, employee.LastName);
            }

            // 4. Add new Employee
            dbContext.Employees.Add
            (
                new Employee()
                {
                    FirstName = "Maria",
                    LastName = "Dimitrova",
                    DepartmentId = dbContext.Departments.First().Id,
                    IsEmployed = 1
                }
            );
            dbContext.SaveChanges();

            // 5. List Employeees Names
            Console.WriteLine("Employees:");
            Console.WriteLine(new string('-', 25));
            foreach (var employee in dbContext.Employees)
            {
                Console.WriteLine("{0} {1}", employee.FirstName, employee.LastName);
            }

        }
    }
}
