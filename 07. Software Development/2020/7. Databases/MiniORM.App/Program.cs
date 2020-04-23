using MiniORM.App.Data;
using System;
using System.Linq;

namespace MiniORM.App
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. MSSQL Connection String
            var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Database=MiniORM;Integrated Security=True";

            // 2. MSSQL Database Context
            var context = new MiniOrmDbContext(connectionString);

            // 3. MSSQL Query
            var employees = context.Employees;
            foreach (var empolyee in employees)
            {
                Console.WriteLine("{0} {1}", empolyee.FirstName, empolyee.LastName);
            }
        }
    }
}
