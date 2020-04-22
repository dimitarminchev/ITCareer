using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.AgeIncrease
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter minions' id: ");
            var minionsIds = Console.ReadLine().Split().ToArray();

            // 1. Connection String
            var connstr = "server=localhost;port=3306;user=root;password=root;database=minionsdb";

            // 2. MySQL Connection
            MySqlConnection conn = new MySqlConnection(connstr);
            conn.Open();

            // 3. SQL Query
            var sqlAll = "SELECT name,age from minionsdb.minions";
            var sqlAge = "SELECT age from minionsdb.minions" +
                        " where minions.id = @id; ";
            var sqlName = "SELECT name from minionsdb.minions" +
                          " where minions.id = @id; ";
            var sqlUpdate = "UPDATE minions SET name = @name, age = @age+1" +
                            " where minions.id = @id;";

            // 4. MySQL Command
            MySqlCommand commandPrint = new MySqlCommand(sqlAll, conn);
            MySqlCommand commandAge;
            MySqlCommand commandName;
            MySqlCommand commandUpdate;

            for (int i = 0; i < minionsIds.Count(); i++)
            {
                commandAge = new MySqlCommand(sqlAge, conn);
                commandAge.Parameters.AddWithValue("@id", minionsIds[i]);
                var age = int.Parse(commandAge.ExecuteScalar().ToString());
                commandName = new MySqlCommand(sqlName, conn);
                commandName.Parameters.AddWithValue("@id", minionsIds[i]);
                var name = commandName.ExecuteScalar().ToString();
                name = name.First().ToString().ToUpper() + name.Substring(1);
                commandUpdate = new MySqlCommand(sqlUpdate, conn);
                commandUpdate.Parameters.AddWithValue("@id", minionsIds[i]);
                commandUpdate.Parameters.AddWithValue("@age", age);
                commandUpdate.Parameters.AddWithValue("@name", name);
                commandUpdate.ExecuteNonQuery();
            }

            // 5. MySQL Reader
            MySqlDataReader reader = commandPrint.ExecuteReader();
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
