namespace CrudWithoutORM.Data
{
    using System.Data.SqlClient;

    /// <summary>
    /// Microsoft SQL Server Database Connetion Class
    /// </summary>
    public static class DataBase
    {
        private static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Shop;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
