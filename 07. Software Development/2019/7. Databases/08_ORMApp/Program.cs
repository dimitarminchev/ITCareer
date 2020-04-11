using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08.ORMApp.Data;
using MiniORM;
namespace _08.ORMApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "server=localhost;database=miniorm;port=3306;user=root;password=root";
            var databaseManager = new DatabaseManager(connectionString, true);
            
            // departments
            List<Department> departments = new List<Department>();
            departments.Add(new Department("Management"));
            departments.Add(new Department("Accounting"));
            departments.Add(new Department("Development"));
            departments.Add(new Department("CEO"));
            departments.Add(new Department("Cleaning"));
            foreach(var department in departments)
            {
                databaseManager.Persist(department);
            }

            // employees
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Gosho", "Poleen", "Parvanov", 0, 1));
            employees.Add(new Employee("Penka", "Severova", "Ivanova", 1, 3));
            employees.Add(new Employee("Tinka", "Petkova", "Marinova", 0, 5));
            foreach (var employee in employees)
            {
                databaseManager.Persist(employee);
            }

            // Print
            IEnumerable<Department> deps = databaseManager.FindAll<Department>();
            foreach (var dep in deps) Console.WriteLine(dep.Name);

            IEnumerable<Employee> emps = databaseManager.FindAll<Employee>();
            foreach (var emp in emps) Console.WriteLine(emp.FirstName + " " + emp.LastName);

        }
    }
}
