using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Minions
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 1. Connection String
            var connstr = "server=localhost;port=3306;user=root;password=root;database=minions";

            // 2. MySQL Connection
            MySqlConnection conn = new MySqlConnection(connstr);
            conn.Open();

            // 3. SQL Query
            var sql = "SELECT name,age FROM minions;";

            // 4. MySQL Command
            MySqlCommand command = new MySqlCommand(sql, conn);

            // 5. MySQL Reader
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Name: {0}, Age: {1}", reader[0], reader[1]);
            }

            // 6. Close MySQL Reader and Connection
            reader.Close();
            conn.Close();
        }
    }
}
