using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AddMinion
{
    class Program
    {
        static void Main(string[] args)
        {
            var minionData = Console.ReadLine().Split().ToArray();
            var minionName = minionData[1];
            int minionAge = int.Parse(minionData[2]);
            var townName = minionData[3];
            var villainData = Console.ReadLine().Split().ToArray();
            var villainName = villainData[1];
            // 1. Connection String
            var connstr = "server=localhost;port=3306;user=root;password=root;database=minionsdb";

            // 2. MySQL Connection
            MySqlConnection conn = new MySqlConnection(connstr);
            conn.Open();

            // 3. SQL Query
            var sql = "SELECT count(*) FROM minionsdb.towns" +
                        " where towns.name = @townName";

            // 4. MySQL Command
            MySqlCommand command = new MySqlCommand(sql, conn);

            // 4.1 Prevent injection
            command.Parameters.AddWithValue("@townName", townName);

            // 4.2 Add town if not exists
            if (int.Parse(command.ExecuteScalar().ToString()) == 0)
            {
                sql = "INSERT INTO Towns(Name) VALUES (@townName)";
                command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@townName", townName);
                command.ExecuteNonQuery();
                Console.WriteLine($"Town {townName} was added to the database.");
            }

            // 4.3.New SQL Query
            sql = "SELECT count(*) FROM minionsdb.villains" +
                   " where villains.Name = @villainName;";

            // 4.4 New MySQL Command
            command = new MySqlCommand(sql, conn);

            // 4.5 Prevent injection again
            command.Parameters.AddWithValue("@villainName", villainName);

            // 4.6 Add villain if not exists
            if (command.ExecuteScalar().ToString() == "0")
            {
                sql = "INSERT INTO Villains (Name, EvilnessFactorId) VALUES (@villainName, 3)";
                command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@villainName", villainName);
                command.ExecuteNonQuery();
                Console.WriteLine($"Villain {villainName} was added to the database.");
            }

            // 4.7 Add minion 
            sql = "INSERT INTO Minions (Name, Age, TownId) VALUES" +
                  " (@minionName, @minionAge, (SELECT towns.id from towns where towns.name = @townName LIMIT 1)); ";
            command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("@minionName", minionName);
            command.Parameters.AddWithValue("@minionAge", minionAge);
            command.Parameters.AddWithValue("@townName", townName);
            command.ExecuteNonQuery();
            Console.WriteLine($"Minion {minionName} was added to the database.");

            // 4.8 Connect minion and vallain 
            sql = "INSERT INTO MinionsVillains(MinionId, VillainId) VALUES" +
                    " ((Select minions.id from minions where minions.name = @minionName Limit 1)," +
                    "(Select villains.id from villains where villains.name = @villainName Limit 1)); ";
            command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("@minionName", minionName);
            command.Parameters.AddWithValue("@villainName", villainName);
            command.ExecuteNonQuery();
            Console.WriteLine($"Successfully added {minionName} to be minion of {villainName}.");


            // 6. Close MySQL Connection
            conn.Close();
        }
    }
}
