using Microsoft.EntityFrameworkCore;
using RestApi.Model;

namespace RestApi.Data
{
    public class MessagesContext : DbContext
    {
        public MessagesContext(DbContextOptions<MessagesContext> options)
            : base(options)
        {
        }

        public DbSet<Message> Messages { get; set; }
    }
}
