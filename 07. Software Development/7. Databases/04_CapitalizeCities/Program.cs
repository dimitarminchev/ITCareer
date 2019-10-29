using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CapitalizeCities
{
    class Program
    {
        static void Main(string[] args)
        {
            string countryName = Console.ReadLine();

            string connectionString = "server=localhost;database=minions;port=3306;user=root;password=root";

            MySqlConnection dbCon = new MySqlConnection(connectionString);
            dbCon.Open();

            using (dbCon)
            {
                int? countryId = (int?)new MySqlCommand($"SELECT Id FROM Countries WHERE Name = '{countryName}'", dbCon).ExecuteScalar();

                if (countryId == null)
                {
                    Console.WriteLine("No town names were affected.");
                }
                else
                {
                    int townsCount = int.Parse(new MySqlCommand($"SELECT COUNT(*) FROM Towns WHERE CountryCode = {countryId}", dbCon).ExecuteScalar().ToString());

                    MySqlDataReader reader = new MySqlCommand($"SELECT * FROM Towns WHERE CountryCode = {countryId}", dbCon).ExecuteReader();

                    var townNamesAffected = new List<String>();
                    var townIdsAffected = new List<int>();

                    using (reader)
                    {
                        if (!reader.HasRows)
                        {
                            Console.WriteLine("No town names were affected.");
                            reader.Close();
                            dbCon.Close();
                            return;
                        }

                        while (reader.Read())
                        {

                            string townName = (string)reader["Name"];
                            int townId = (int)reader["Id"];

                            townNamesAffected.Add(townName.ToUpper());
                            townIdsAffected.Add(townId);
                        }
                    }

                    for (int i = 0; i < townIdsAffected.Count; i++)
                    {
                        new MySqlCommand($"UPDATE Towns SET Name = '{townNamesAffected[i].ToUpper()}' WHERE Id = {townIdsAffected[i]}", dbCon).ExecuteNonQuery();
                    }

                    Console.WriteLine($"{townsCount} town names were affected.");
                    Console.WriteLine($"[{String.Join(", ", townNamesAffected)}]");
                }
            }
        }
    }
}
