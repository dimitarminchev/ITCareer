using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace _06.AllMinionsNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "server=localhost;database=minions;port=3306;user=root;password=root";
            MySqlConnection dbCon = new MySqlConnection(connectionString);
            dbCon.Open();

            List<string> minionsInitial = new List<string>();
            List<string> minionsArranged = new List<string>();

            using (dbCon)
            {
                MySqlCommand command = new MySqlCommand("SELECT Name FROM Minions", dbCon);

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
                        minionsInitial.Add((string)reader["Name"]);
                    }
                }
            }

            while (minionsInitial.Count > 0)
            {
                minionsArranged.Add(minionsInitial[0]);
                minionsInitial.RemoveAt(0);

                if (minionsInitial.Count > 0)
                {
                    minionsArranged.Add(minionsInitial[minionsInitial.Count - 1]);
                    minionsInitial.RemoveAt(minionsInitial.Count - 1);
                }
            }

            minionsArranged.ForEach(m => Console.WriteLine(m));
        }
    }
}
