using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinionsNames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter villain's ID: ");
            int villainID = int.Parse(Console.ReadLine());
            // 1. Connection String
            var connstr = "server=localhost;port=3306;user=root;password=root;database=minionsdb";

            // 2. MySQL Connection
            MySqlConnection conn = new MySqlConnection(connstr);
            conn.Open();

            // 3. SQL Query
            var sql = "SELECT minions.name FROM minionsdb.minionsvillains" +
                      " join minions on minionsvillains.MinionId = minions.id" +
                      $" where minionsvillains.VillainId = @villainID; ";

            // 4. MySQL Command
            MySqlCommand command = new MySqlCommand(sql, conn);

            //4.1 Prevent injection
            command.Parameters.AddWithValue("@villainID", villainID);

            // 5. MySQL Reader
            MySqlDataReader reader = command.ExecuteReader();
            bool hasNames = false;
            while (reader.Read())
            {
                hasNames = true;
                Console.WriteLine("Name: {0}", reader[0]);
            }

            if (hasNames == false)
            {
                Console.WriteLine($"No villain with ID {villainID} exists in the database.");
            }

            // 6. Close MySQL Reader and Connection
            reader.Close();
            conn.Close();
        }
    }
}
