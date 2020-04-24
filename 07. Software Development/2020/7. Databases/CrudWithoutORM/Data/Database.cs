using System.Data.SqlClient;

namespace CrudWithoutORM.Data
{
    public static class DataBase
    {
        private static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Database=shop;Integrated Security=True";
        
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
