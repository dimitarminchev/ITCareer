using System;

namespace _03.MinionsNames
{
    using System.Data.SqlClient;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter villain's ID: ");
            int villainID = int.Parse(Console.ReadLine());

            using (var conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=minions;Integrated Security=true"))
            {
                conn.Open();
                SqlCommand sql = new SqlCommand
                (
                    "SELECT minions.name " + 
                    "FROM minionsvillains " +
                    "JOIN minions on minionsvillains.MinionId = minions.id " +
                   $"WHERE minionsvillains.VillainId = @villainID", conn
                );
                sql.Parameters.AddWithValue("@villainID", villainID);
                var reader = sql.ExecuteReader();

                bool hasNames = false;
                int i = 1;
                while (reader.Read())
                {
                    hasNames = true;
                    Console.WriteLine("{0}. {1}", i++, reader[0]);
                }
                if (hasNames == false)
                {
                    Console.WriteLine($"No villain with ID {villainID} exists in the database.");
                }

                reader.Close();
                conn.Close();
            }
        }
    }
}
