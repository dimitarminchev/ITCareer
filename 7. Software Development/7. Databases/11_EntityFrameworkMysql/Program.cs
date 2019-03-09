using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// namespaces
using _11_EntityFrameworkMysql.Models;
using _11_EntityFrameworkMysql.Business;

namespace _11_EntityFrameworkMysql
{
    class Program
    {
        static void Main(string[] args)
        {            
            var context = new employeesContext();

            // Select
            {
                foreach (var department in context.Departments)
                Console.WriteLine(department.DeptName);
            }

            // Update
            {
                var department = context.Departments.FirstOrDefault(d => d.DeptNo == "d002");
                department.DeptName = "Money"; // Finances => Money
                context.SaveChanges();
            }

            // Delete
            {
                var department = context.Departments.FirstOrDefault(d => d.DeptNo == "d002");
                context.Departments.Remove(department);
                context.SaveChanges();
            }
        }
    }
}
