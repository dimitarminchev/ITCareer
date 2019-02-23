using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// MySQL
using MySql.Data;
using MySql.Data.MySqlClient;

namespace _1.Minions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connection String
            string connstr = "server=localhost;database=minions;port=3306;user=root;password=root";

            // MySQL Connection
            MySqlConnection con = new MySqlConnection(connstr);
            con.Open();

            // SQL
            var sql = "SELECT Villains.Name, EvilnessFactors.Name FROM Villains " +
                      "LEFT JOIN EvilnessFactors " +
                      "ON EvilnessFactors.Id = Villains.EvilnessFactorId";

            // MySQL Command
            MySqlCommand cmd = new MySqlCommand(sql, con);

            // MySQL Reader
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Villain: {0}, EvilnessFactor: {1}", reader[0], reader[1]);
            }

            // Close Reader and Connection
            reader.Close();
            con.Close();
        }
    }
}
