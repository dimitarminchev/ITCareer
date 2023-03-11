
namespace MiniORM.App.Data
{
    using MiniORM;
    using MiniORM.App.Data.Etities;

    /// <summary>
    /// MiniORM database context
    /// </summary>
    public class EmployeesDbContext : DbContext
    {
        public EmployeesDbContext(string connectionString) : base(connectionString)
        {
            // empty
        }

        /// <summary>
        /// Employees table
        /// </summary>
        public DbSet<Employee> Employees { get; }

        /// <summary>
        /// Departments table
        /// </summary>
        public DbSet<Department> Departments { get; }

        /// <summary>
        /// Projects table
        /// </summary>
        public DbSet<Project> Projects { get; }

        /// <summary>
        /// EmployeesProjects table
        /// </summary>
        public DbSet<EmployeeProject> EmployeesProjects { get; }
    }
}
