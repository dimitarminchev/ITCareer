using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//MySQL
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AddMinions
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();

            string connectionString = "server=localhost;database=minions;port=3306;user=root;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            string[] minionInputString = Console.ReadLine().Split();
            string[] villainInputString = Console.ReadLine().Split();

            string townName = minionInputString[3];
            string checkTownExistence = $"SELECT COUNT(*) FROM Towns WHERE Name = \"{townName}\";";

            MySqlCommand findTownSqlCommand = new MySqlCommand(checkTownExistence, connection);
            bool doesTownExist = findTownSqlCommand.ExecuteScalar().ToString() == "0" ? false : true;
            if(!doesTownExist)
            {
                string insertTownString = "INSERT INTO Towns (Name, CountryCode) " +
                                          "VALUES " +
                                          $"({townName}, 2);";
                // Bulgariq na 7 kontinenta

                MySqlCommand insertTownCommand = new MySqlCommand(insertTownString, connection);
                insertTownCommand.ExecuteNonQuery();

                result.AppendLine($"Town {townName} added to the database.");
            }

            string villainName = villainInputString[1];
            string checkVillainExistenceString = $"SELECT COUNT(*) FROM Villains WHERE Name = \"{villainName}\"";
            MySqlCommand findVillainCommand = new MySqlCommand(checkVillainExistenceString, connection);
            bool doesVillainExist = findVillainCommand.ExecuteScalar().ToString() == "0" ? false : true;

            if(!doesVillainExist)
            {
                string insertVillainString = "INSERT INTO Villains (Name, EvilnessFactorId) " +
                                             "VALUES " +
                                             $"(\"{villainName}\", 3);";

                MySqlCommand insertVillainCommand = new MySqlCommand(insertVillainString, connection);
                insertVillainCommand.ExecuteNonQuery();

                result.AppendLine($"Villain {villainInputString[1]} added to the database.");
            }

            string findTownId = $"SELECT Id FROM Towns WHERE Name = \"{townName}\";";
            MySqlCommand findTownIdCommand = new MySqlCommand(findTownId, connection);
            int townId = int.Parse(findTownIdCommand.ExecuteScalar().ToString());

            string findVillainId = $"Select Id FROM Villains WHERE Name = \"{villainName}\";";
            MySqlCommand findVillainIdCommand = new MySqlCommand(findVillainId, connection);
            int villainId = int.Parse(findVillainIdCommand.ExecuteScalar().ToString());

            string addMinionString = "INSERT INTO Minions (Name, Age, TownId) " +
                                     "VALUES " +
                                     $"(\"{minionInputString[1]}\", \"{minionInputString[2]}\", {townId})";
            MySqlCommand addMinionCommand = new MySqlCommand(addMinionString, connection);
            addMinionCommand.ExecuteNonQuery();

            string minionName = minionInputString[1];
            string findMinionIdString = $"SELECT Id FROM Minions WHERE Name = \"{minionName}\";";
            MySqlCommand findMinionIdCommand = new MySqlCommand(findMinionIdString, connection);
            int minionId = int.Parse(findMinionIdCommand.ExecuteScalar().ToString());

            string addVillainMinionRelationString = "INSERT INTO MinionsVillains (MinionId, VillainId) " +
                                                    "VALUE " +
                                                    $"({minionId}, {villainId});";
            MySqlCommand addVillainMinionRelationCommand = new MySqlCommand(addVillainMinionRelationString, connection);
            addVillainMinionRelationCommand.ExecuteNonQuery();

            result.AppendLine($"Successfully added {minionName} to be minion of {villainName}");
            Console.WriteLine(result.ToString());
        }
    }
}
