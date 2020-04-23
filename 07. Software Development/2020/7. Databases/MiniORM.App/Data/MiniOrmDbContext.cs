using System;
using System.Collections.Generic;
using System.Text;

namespace MiniORM.App.Data
{
    using Entities;

    public class MiniOrmDbContext : DbContext
    {
        public MiniOrmDbContext(string connectionString) : base(connectionString)
        {
            // nope
        }

        public DbSet<Employee> Employees { get;  }

        public DbSet<Department> Departments { get; }

        public DbSet<Project> Projects { get; }

        public DbSet<EmployeeProject> EmployeesProjects { get; }
    }
}
