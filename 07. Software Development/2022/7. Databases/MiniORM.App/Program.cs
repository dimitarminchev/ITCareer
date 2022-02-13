using System;

using MiniORM.App.Data;
using MiniORM.App.Data.Etities;

namespace MiniORM.App 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. Microsoft SQL Server Connection String
            var connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MiniORM;Integrated Security=True";

            // 2. MiniORM Database Context
            var dbContext = new EmployeesDbContext(connString);

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


