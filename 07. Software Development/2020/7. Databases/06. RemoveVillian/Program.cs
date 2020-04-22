using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RemoveVillian
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter villain id: ");
            int villainId = int.Parse(Console.ReadLine());

            // 1. Connection String
            var connstr = "server=localhost;port=3306;user=root;password=root;database=minionsdb";

            // 2. MySQL Connection
            MySqlConnection conn = new MySqlConnection(connstr);
            conn.Open();

            // 3. SQL Query
            var sql = "SELECT count(*) FROM minionsdb.villains" +
                        " where villains.id = @villainId ;";

            // 4. MySQL Command
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.Parameters.AddWithValue("@villainId", villainId);

            // 5 Check if the villain exists
            bool existsVillain = int.Parse(command.ExecuteScalar().ToString()) > 0;
            if (existsVillain == false)
            {
                Console.WriteLine("No such villain was found.");
            }
            else
            {
                // Get villain's name
                sql = "SELECT name FROM minionsdb.villains" +
                        " where villains.id = @villainId ;";
                command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@villainId", villainId);
                string villainName = command.ExecuteScalar().ToString();

                // Get expected rows that has to be affected
                sql = "Select count(*) from minionsvillains " +
                      " WHERE  villainId = @villainId;";
                command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@villainId", villainId);
                int expectedAffectedRows = int.Parse(command.ExecuteScalar().ToString()) + 1;

                // Release minions
                sql = "start transaction;";
                command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                sql = "update minionsdb.minionsvillains set VillainId = null " +
                      " WHERE  villainId = @villainId;";
                command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@villainId", villainId);
                int rowsAffected = command.ExecuteNonQuery();

                // Remove villain from database
                sql = "DELETE from minionsdb.villains where id=@villainId ";
                command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("@villainId", villainId);
                rowsAffected += command.ExecuteNonQuery();

                // Check if transaction is successful
                if (rowsAffected == expectedAffectedRows)
                {
                    sql = "Commit; ";
                    Console.WriteLine($"{villainName} was deleted.");
                    Console.WriteLine($"{rowsAffected - 1} minions were released.");
                }
                else
                {
                    sql = "Rollback; ";
                    Console.WriteLine("No changes were made due to unsuccessful transaction");
                }
                command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
            }

            // 6. Close MySQL Connection
            conn.Close();
        }
    }
}
