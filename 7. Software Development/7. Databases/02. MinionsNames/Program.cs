using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// MySQL
using MySql.Data;
using MySql.Data.MySqlClient;

namespace _02.MinionsNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string connstr = "server=localhost;database=minions;port=3306;user=root;password=root";

            MySqlConnection connection = new MySqlConnection(connstr);
            connection.Open();

            int input = int.Parse(Console.ReadLine());

            string identifyVillainSQL = ($"SELECT Name FROM Villains WHERE Id = {input}");
            MySqlCommand command = new MySqlCommand(identifyVillainSQL, connection);
            try
            {
                string villainName = command.ExecuteScalar().ToString();
                Console.WriteLine($"Villain: {villainName}");
            }
            catch
            {
                Console.WriteLine($"Villain with ID {input} not found");
                return;
            }
            
            string findMinionsSQL = ("SELECT m.Name, m.Age From Minions AS m " +
                                     "JOIN minionsvillains AS mv ON mv.MinionId = m.Id " +
                                     $"WHERE mv.villainId = {input};");

            command = new MySqlCommand(findMinionsSQL, connection);
            MySqlDataReader reader = command.ExecuteReader();
            int counter = 1;
            while(reader.Read())
            {
                Console.WriteLine($"{counter} {reader[0]} {reader[1]}");
                counter++;
            }

            
            if(counter == 1)
            {
                Console.WriteLine("No minions");
            }
        }
    }
}
