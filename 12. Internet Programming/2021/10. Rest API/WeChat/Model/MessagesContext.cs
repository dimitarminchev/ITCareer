using Microsoft.EntityFrameworkCore;

namespace WeChat.Model
{
    public class MessagesContext : DbContext
    {

        public MessagesContext()
        {
            ;;
        }
        public MessagesContext(DbContextOptions<MessagesContext> options) : base(options)
        {
            ;;
        }

        public DbSet<Message> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WeChat");
        }
    }
}
