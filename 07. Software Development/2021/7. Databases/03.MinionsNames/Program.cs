using System;

namespace _03.MinionsNames
{
    using System.Data.SqlClient;

    class Program
    {
        static void Main(string[] args)
        {

            using (var conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=minions;Integrated Security=true"))
            {
                conn.Open();
                // T-SQL
                SqlCommand sql = new SqlCommand
                (
                    "SELECT V.Name, COUNT(MV.VillainId) " +
                    "FROM Villains as V " +
                    "JOIN MinionsVillains AS MV on MV.VillainId = V.Id " +
                    "GROUP BY MV.VillainId, V.Name " +
                    "HAVING COUNT(MV.VillainId) > 3", conn
                );
                var reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("{0} -> {1}", reader[0], reader[1]);
                }
            }
        }
    }
}
