using System;

namespace _07.AllMinionNames
{
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            // Minion Names List
            var minionNamesList = new List<string>();

            using (var conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=minions;Integrated Security=true"))
            {
                conn.Open();

                // Get Minions Names and write them to thew List
                SqlCommand command = new SqlCommand("SELECT minions.name FROM minions", conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    minionNamesList.Add(reader[0].ToString());
                }

                // Print in the given order 
                for (int i = 0; i < minionNamesList.Count() / 2; i++)
                {
                    Console.WriteLine(minionNamesList[i]);
                    Console.WriteLine(minionNamesList[minionNamesList.Count() - i - 1]);
                }
                if (minionNamesList.Count() % 2 != 0)
                {
                    Console.WriteLine(minionNamesList[minionNamesList.Count() / 2 + 1]);
                }
            }
           
        }
    }
}
