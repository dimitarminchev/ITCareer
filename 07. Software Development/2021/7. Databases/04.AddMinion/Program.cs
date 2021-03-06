using System;

namespace _04.AddMinion
{
    using System.Data.SqlClient;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            // Minion
            Console.WriteLine("Minion [name age town]: ");
            var minionData = Console.ReadLine().Split().ToArray();
            var minionName = minionData[0];
            int minionAge = int.Parse(minionData[1]);
            var townName = minionData[2];

            // Villain
            Console.WriteLine("Villain [name]: ");
            var villainName = Console.ReadLine();

            // Process
            using (var conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=minions;Integrated Security=true"))
            {
                conn.Open();

                // 1. Search Towns By Name
                SqlCommand sql = new SqlCommand
                (
                    "SELECT count(*) FROM towns WHERE towns.name = @townName", conn
                );
                sql.Parameters.AddWithValue("@townName", townName);

                // 2. Add town to the database if not exists
                if (int.Parse(sql.ExecuteScalar().ToString()) == 0)
                {
                    sql = new SqlCommand("INSERT INTO Towns (Name, CountryCode) VALUES (@townName, 2)", conn);
                    sql.Parameters.AddWithValue("@townName", townName);
                    sql.ExecuteNonQuery();
                    Console.WriteLine($"Town {townName} was added to the database.");
                }

                // 3. Search Villain by Name
                sql = new SqlCommand
                (
                   "SELECT count(*) FROM villains WHERE villains.Name = @villainName", conn
                );
                sql.Parameters.AddWithValue("@villainName", villainName);

                // 4. Add Villain to the database if not exists
                if (int.Parse(sql.ExecuteScalar().ToString()) == 0)
                {
                    sql = new SqlCommand("INSERT INTO Villains (Name, EvilnessFactorId) VALUES (@villainName, 4)", conn);
                    sql.Parameters.AddWithValue("@villainName", villainName);
                    sql.ExecuteNonQuery();
                    Console.WriteLine($"Villain {villainName} was added to the database.");
                }

                // 5. Add Minion 
                sql = new SqlCommand
                (
                     "INSERT INTO Minions (Name, Age, TownId) VALUES (@minionName, @minionAge, " +
                     "(SELECT towns.id FROM towns WHERE towns.name = @townName)) ", conn
                );
                sql.Parameters.AddWithValue("@minionName", minionName);
                sql.Parameters.AddWithValue("@minionAge", minionAge);
                sql.Parameters.AddWithValue("@townName", townName);
                sql.ExecuteNonQuery();
                Console.WriteLine($"Minion {minionName} was added to the database.");

                // 6. Connect Minion and Villain 
                sql = new SqlCommand
                (
                    "INSERT INTO MinionsVillains (MinionId, VillainId) VALUES " +
                    "((SELECT minions.id FROM minions WHERE minions.name = @minionName), " +
                    "(SELECT villains.id FROM villains WHERE villains.name = @villainName))", conn
                );
                sql.Parameters.AddWithValue("@minionName", minionName);
                sql.Parameters.AddWithValue("@villainName", villainName);
                sql.ExecuteNonQuery();
                Console.WriteLine($"Successfully added {minionName} to be minion of {villainName}.");
            }
        }
    }
}
