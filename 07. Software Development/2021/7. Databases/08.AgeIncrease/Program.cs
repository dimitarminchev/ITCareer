using System;

namespace _08.AgeIncrease
{
    using System.Data.SqlClient;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter minions' id: ");
            var minionsIds = Console.ReadLine().Split().ToArray();

            using (var conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=minions;Integrated Security=true"))
            {
                conn.Open();

                // Process All Minnions
                foreach(var minionId in minionsIds)
                {
                    // Get Minion Age
                    var commandAge = new SqlCommand("SELECT age FROM minions WHERE minions.id = @id", conn);
                    commandAge.Parameters.AddWithValue("@id", minionId);
                    var minionAge = int.Parse(commandAge.ExecuteScalar().ToString());

                    // Select Minion By Id
                    var commandName = new SqlCommand("SELECT name FROM minions  where minions.id = @id", conn);
                    commandName.Parameters.AddWithValue("@id", minionId);
                    var name = commandName.ExecuteScalar().ToString();
                    name = name.First().ToString().ToUpper() + name.Substring(1);

                    // Update Minion
                    var commandUpdate = new SqlCommand("UPDATE minions SET name = @name, age = @age+1 WHERE minions.id = @id", conn);
                    commandUpdate.Parameters.AddWithValue("@id", minionId);
                    commandUpdate.Parameters.AddWithValue("@age", minionAge);
                    commandUpdate.Parameters.AddWithValue("@name", name);
                    commandUpdate.ExecuteNonQuery();
                }

                // Print All Minions Names
                SqlCommand commandPrint = new SqlCommand("SELECT name,age FROM minions", conn);
                SqlDataReader reader = commandPrint.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("Name: {0}, Age: {1}", reader[0], reader[1]);
                }

                // CleanUp
                reader.Close();
                conn.Close();
            }
        }
    }
}
