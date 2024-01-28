using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst.Models
{
    public partial class TasksContext : DbContext
    {
        public virtual DbSet<Task> Tasks { get; set; }

        public TasksContext()
        {
            ; ;
        }

        public TasksContext(DbContextOptions<TasksContext> options) : base(options)
        {
            ; ;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Tasks;");
        }

    }

}