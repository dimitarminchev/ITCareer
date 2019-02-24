using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace _05.RemoveVilian
{
    class Program
    {
        static void Main(string[] args)
        {
            int villainId = int.Parse(Console.ReadLine());

            string connectionString = "server=localhost;database=minions;port=3306;user=root;password=root";
            MySqlConnection dbCon = new MySqlConnection(connectionString);
            dbCon.Open();

            using (dbCon)
            {
                MySqlCommand command = new MySqlCommand("SELECT Id FROM Villains WHERE Id = @Id", dbCon);
                command.Parameters.AddWithValue("@Id", villainId);
                int? result = (int?)command.ExecuteScalar();

                if (result == null)
                {
                    Console.WriteLine("No such villain was found.");
                    dbCon.Close();
                    return;
                }

                command = new MySqlCommand("SELECT COUNT(*) FROM MinionsVillains WHERE VillainId = @Id", dbCon);
                command.Parameters.AddWithValue("@Id", villainId);
                int minionsCount = int.Parse(command.ExecuteScalar().ToString());

                command = new MySqlCommand("DELETE FROM MinionsVillains WHERE VillainId = @Id", dbCon);
                command.Parameters.AddWithValue("@Id", villainId);
                command.ExecuteNonQuery();

                command = new MySqlCommand("SELECT Name FROM Villains WHERE Id = @Id", dbCon);
                command.Parameters.AddWithValue("@Id", villainId);
                string villainName = (string)command.ExecuteScalar();

                command = new MySqlCommand("DELETE FROM Villains WHERE Id = @Id", dbCon);
                command.Parameters.AddWithValue("@Id", villainId);
                command.ExecuteNonQuery();

                Console.WriteLine($"{villainName} was deleted.");
                Console.WriteLine($"{minionsCount} minions were released.");
            }
        }
    }
}
