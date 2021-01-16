using Microsoft.EntityFrameworkCore;

namespace CHUSHKA.Models
{
    public class ChushkaContext : DbContext
    {
        // Constructors
        public ChushkaContext()
        {
            ;;
        }
        public ChushkaContext(DbContextOptions<ChushkaContext> options) : base(options)
        {
            ;;
        }

        // Tables
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }


        // Relationships
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId);

            modelBuilder.Entity<Order>()
                .HasOne(p => p.Product)
                .WithMany(p => p.Orders)
                .HasForeignKey(o => o.ProductId);
        }
        // Connection String
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ChushkaDb;Trusted_Connection=True");
        }
    }
}
