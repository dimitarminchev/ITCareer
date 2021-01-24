using CodeFirst.Entity;
using Microsoft.EntityFrameworkCore;
using System;

namespace CodeFirst
{
    public class CodeFirstContext : DbContext
    {
        public virtual DbSet<Author> Authors { get; set; }

        public virtual DbSet<Biography> Biographies { get; set; }

        public virtual DbSet<Company> Companies { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<Book> Books { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<BookCategory> BookCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasOne(a => a.Biography)
                .WithOne(b => b.Author)
                .HasForeignKey<Biography>(c => c.AuthorId);

            modelBuilder.Entity<Company>()
                .HasMany(a => a.Employees)
                .WithOne(b => b.Company)
                .HasForeignKey(c => c.CompanyId);

            modelBuilder.Entity<BookCategory>()
                .HasKey(bc => new { bc.BookId, bc.CategoryId });

            modelBuilder.Entity<BookCategory>()
                .HasOne(bc => bc.Category)
                .WithMany(c => c.BooksCategories)
                .HasForeignKey(bc => bc.BookId);

            modelBuilder.Entity<BookCategory>()
                .HasOne(bc => bc.Category)
                .WithMany(c => c.BooksCategories)
                .HasForeignKey(bc => bc.CategoryId);

            // base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = @"Data Source=(localdb)\ProjectsV13; Initial Catalog=CodeFirstDB";
            optionsBuilder.UseSqlServer(conn);
            optionsBuilder.UseLazyLoadingProxies();
            // base.OnConfiguring(optionsBuilder);
        }
    }
}
