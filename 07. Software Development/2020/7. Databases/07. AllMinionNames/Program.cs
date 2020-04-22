using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AllMinionNames
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Connection String
            var connstr = "server=localhost;port=3306;user=root;password=root;database=minionsdb";

            // 2. MySQL Connection
            MySqlConnection conn = new MySqlConnection(connstr);
            conn.Open();

            // 3. SQL Query
            var sql = "SELECT minions.name FROM minionsdb.minions";

            // 4. MySQL Command
            MySqlCommand command = new MySqlCommand(sql, conn);

            // 5. MySQL Reader
            var minionNames = new List<string>();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                minionNames.Add(reader[0].ToString());
            }

            // 6. Print in the given order 
            for (int i = 0; i < minionNames.Count() / 2; i++)
            {
                Console.WriteLine(minionNames[i]);
                Console.WriteLine(minionNames[minionNames.Count() - i - 1]);
            }
            if (minionNames.Count() % 2 != 0)
                Console.WriteLine(minionNames[minionNames.Count() / 2 + 1]);

            // 7. Close MySQL Reader and Connection
            reader.Close();
            conn.Close();
        }
    }
}
