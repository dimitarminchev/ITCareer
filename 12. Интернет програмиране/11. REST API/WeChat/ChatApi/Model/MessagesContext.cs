using Microsoft.EntityFrameworkCore;

namespace ChatApi.Model
{
    public class MessagesContext : DbContext
    {

        public DbSet<Message> Messages { get; set; }

        public MessagesContext()
        {
            ; ;
        }
        public MessagesContext(DbContextOptions<MessagesContext> options) : base(options)
        {
            ; ;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Messages;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
