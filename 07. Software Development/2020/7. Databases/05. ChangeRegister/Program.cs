using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ChangeRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter country: ");
            var countryName = Console.ReadLine();

            // 1. Connection String
            var connstr = "server=localhost;port=3306;user=root;password=root;database=minionsdb";

            // 2. MySQL Connection
            MySqlConnection conn = new MySqlConnection(connstr);
            conn.Open();

            // 3. SQL Query
            var sql = "SELECT countries.id FROM minionsdb.countries" +
                       " where countries.name = @countryName LIMIT 1; ";

            // 4. MySQL Command
            MySqlCommand command = new MySqlCommand(sql, conn);

            // 4.1 Prevent injection
            command.Parameters.AddWithValue("@countryName", countryName);
            int id = int.Parse(command.ExecuteScalar().ToString());

            // 4.2 New SQL Query
            sql = "SELECT towns.id, towns.name FROM minionsdb.towns" +
                      " Where towns.CountryCode= @id; ";

            // 4.3 MySQL Command
            command = new MySqlCommand(sql, conn);

            // 4.4 Prevent injection
            command.Parameters.AddWithValue("@id", id);
            var townNames = new Dictionary<int, string>();

            // 5. MySQL Reader
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                townNames.Add(int.Parse(reader[0].ToString()), reader[1].ToString().ToUpper());
            }

            foreach (var item in townNames)
            {
                // 6 Update SQL Query
                sql = "UPDATE towns SET name = @name" +
                          " WHERE id=@id;";

                // 6.1 MySQL Update Command
                command = new MySqlCommand(sql, conn);

                // 6.2 Prevent injection
                command.Parameters.AddWithValue("@name", item.Value);
                command.Parameters.AddWithValue("@id", item.Key);
            }

            if (townNames.Count() > 0)
            {
                Console.WriteLine($"{townNames.Count()} town names were affected.");
                Console.WriteLine("[" + string.Join(", ", townNames.Values) + "]");
            }
            else
            {
                Console.WriteLine("No town names were affected.");
            }

            // 6. Close MySQL Reader and Connection
            reader.Close();
            conn.Close();
        }
    }
}
