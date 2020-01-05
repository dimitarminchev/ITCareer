using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Entity
{
    public class CodeFirstContext : DbContext
    {
        // Constructors
        public CodeFirstContext()
        {
            ;;
        }
        public CodeFirstContext(DbContextOptions<CodeFirstContext> options) : base(options)
        {
            ;;
        }

        // Tables
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Biography> Biographies { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<BookCategory> BookCategories { get; set; }

        // Relationships
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasOne(a => a.Biography)
                .WithOne(a => a.Author)
                .HasForeignKey<Biography>(b => b.AuthorId);

            modelBuilder.Entity<Company>()
                .HasMany(e => e.Employees)
                .WithOne(c => c.Company)
                .HasForeignKey(c => c.CompanyId);

            modelBuilder.Entity<BookCategory>()
                .HasKey(bc => new { bc.BookId, bc.CategoryId });

            modelBuilder.Entity<BookCategory>()
                .HasOne(bc => bc.Book)
                .WithMany(bc => bc.BookCategories)
                .HasForeignKey(bc => bc.BookId);

            modelBuilder.Entity<BookCategory>()
                .HasOne(bc => bc.Category)
                .WithMany(c => c.BookCategories)
                .HasForeignKey(bc => bc.CategoryId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CodeFirstDb;Trusted_Connection=True");
            optionBuilder.UseLazyLoadingProxies();
        }
    }
}
