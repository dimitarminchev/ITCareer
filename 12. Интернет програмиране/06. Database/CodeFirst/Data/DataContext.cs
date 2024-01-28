using Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class DataContext : DbContext
    {
        public virtual DbSet<Author> Authors { get; set; }

        public virtual DbSet<Biography> Biographies { get; set; }

        public virtual DbSet<Book> Books { get; set; }

        public virtual DbSet<BookCategory> BookCategories { get; set; }
        
        public virtual DbSet<Category> Categories { get; set; }
       
        public virtual DbSet<Company> Companies { get; set; }
       
        public virtual DbSet<Employee> Employees { get; set; }

        public DataContext()
        {
            ;;
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            ;;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasOne(a => a.Biography)
                .WithOne(b => b.Author)
                .HasForeignKey<Biography>(b => b.AuthorId); 

            modelBuilder.Entity<Company>()
                .HasMany(c => c.Employees)
                .WithOne(e => e.Company)
                .HasForeignKey(e => e.CompanyId);

            modelBuilder.Entity<BookCategory>()
                .HasKey(bc => new { bc.BookId, bc.CategoryId });

            modelBuilder.Entity<BookCategory>()
                .HasOne(bc => bc.Book)
                .WithMany(b => b.BookCategories)
                .HasForeignKey(bc => bc.BookId);

            modelBuilder.Entity<BookCategory>()
                .HasOne(bc => bc.Category)
                .WithMany(c => c.BookCategories)
                .HasForeignKey(bc => bc.CategoryId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookStore;");
            optionBuilder.UseLazyLoadingProxies();
        }
    }
}
