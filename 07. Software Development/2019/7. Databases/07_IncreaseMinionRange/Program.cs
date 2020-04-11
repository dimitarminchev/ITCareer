using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace _07.IncreaseMinionRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] selectedIds = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string connectionString = "server = localhost; database = minions; port = 3306; user = root; password = root";
            MySqlConnection dbCon = new MySqlConnection(connectionString);
            dbCon.Open();

            List<int> minionIds = new List<int>();
            List<string> minionaNames = new List<string>();
            List<int> minionAges = new List<int>();

            using (dbCon)
            {
                MySqlCommand command = new MySqlCommand($"SELECT * FROM Minions WHERE Id IN ({String.Join(", ", selectedIds)})", dbCon);
                MySqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        dbCon.Close();
                        return;
                    }

                    while (reader.Read())
                    {
                        minionIds.Add((int)reader["Id"]);
                        minionaNames.Add((string)reader["Name"]);
                        minionAges.Add((int)reader["Age"]);
                    }
                }

                for (int i = 0; i < minionIds.Count; i++)
                {
                    int id = minionIds[i];
                    string name = String.Join(" ", minionaNames[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList().Select(n => n = char.ToUpper(n.First()) + n.Substring(1).ToLower()).ToArray());
                    int age = minionAges[i] + 1;

                    command = new MySqlCommand("UPDATE Minions SET Name = @name, Age = @age WHERE Id = @Id", dbCon);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@age", age);
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                }

                command = new MySqlCommand($"SELECT * FROM Minions", dbCon);
                reader = command.ExecuteReader();

                using (reader)
                {
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        dbCon.Close();
                        return;
                    }

                    while (reader.Read())
                    {
                        Console.WriteLine($"{(int)reader["Id"]} {(string)reader["Name"]} {(int)reader["Age"]}");
                    }
                }
            }
        }
    }
}
