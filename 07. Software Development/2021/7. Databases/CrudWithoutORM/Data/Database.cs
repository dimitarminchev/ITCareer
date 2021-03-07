
namespace CrudWithoutORM.Data
{
    using System.Data.SqlClient;

    /// <summary>
    /// Microsoft SQL Server Database Connetion Class
    /// </summary>
    public static class DataBase
    {
        private static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Database=shop;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
