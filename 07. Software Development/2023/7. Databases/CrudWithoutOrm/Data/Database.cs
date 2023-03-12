using System.Data.SqlClient;

/// <summary>
/// Task "CRUD without ORM" namespace.
/// </summary>
namespace CrudWithoutOrm.Data
{
    /// <summary>
    /// Task "CRUD without ORM" database class
    /// </summary>
    public class Database
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Products;Integrated Security=True";

        /// <summary>
        /// Get SQL Connection
        /// </summary>
        /// <returns>SQL Connection</returns>
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}
