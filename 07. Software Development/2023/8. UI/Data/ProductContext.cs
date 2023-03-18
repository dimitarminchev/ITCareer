using Data.Model;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// Data Namespace
/// </summary>
namespace Data
{
    /// <summary>
    /// ProductContext
    /// </summary>
    public class ProductContext : DbContext
    {
        /// <summary>
        /// Connection String
        /// </summary> 
        private const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Products;Integrated Security=True;";

        /// <summary>
        /// Products
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public ProductContext()
        {
            // Create the database automaticly
            Database.EnsureCreated();
        }

        /// <summary>
        /// Connection string to Microsoft SQL Server
        /// </summary> 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}