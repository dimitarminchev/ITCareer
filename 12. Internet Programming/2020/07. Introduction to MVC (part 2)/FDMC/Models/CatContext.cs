using Microsoft.EntityFrameworkCore;

namespace FDMC.Models
{
    public class CatContext : DbContext
    {
        public CatContext()
        {
            ;;
        }

        public CatContext(DbContextOptions<CatContext> options) : base(options)
        {
            ;; 
        }

        public DbSet<Cat> Cats { get; set; }
    }
}
