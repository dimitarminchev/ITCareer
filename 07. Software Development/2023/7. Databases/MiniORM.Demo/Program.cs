using MiniORM.App.Data.Etities;
using MiniORM.App.Data;

namespace MiniORM.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Microsoft SQL Server Connection String
            string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MiniORM;Integrated Security=True";

            // 2. MiniORM Database Context
            EmployeesDbContext dbContext = new EmployeesDbContext(connString);

            // 3. List Employeees Names
            Console.WriteLine("Employees:");
            Console.WriteLine(new string('-', 25));
            foreach (Employee employee in dbContext.Employees)
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