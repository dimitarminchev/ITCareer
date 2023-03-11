using System;
using System.Data.SqlClient;

/// <summary>
/// Task "Minions" namespace
/// </summary>
namespace Minions
{
    /// <summary>
    /// Task "Minions" main program class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Task "Minions" main program method
        /// </summary>
        /// <param name="args">No arguments needed</param>
        public static void Main(string[] args)
        {
            // Connection sTring
            string connStr = "Server=(localdb)\\MSSQLLocalDB;Database=minions;Integrated Security=true";

            // Step 1. Connection
            using (SqlConnection sqlConn = new SqlConnection(connStr))
            {
                sqlConn.Open();

                // SQL
                string sqlQuery = "SELECT [name],[age] FROM [minions]"; // 0 = name, 1 = age

                // Step 2. Command
                SqlCommand cmd = new SqlCommand(sqlQuery, sqlConn);

                // Step 3. DataReader
                using (SqlDataReader sqlReader = cmd.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        Console.WriteLine($"Name: {sqlReader[0]}, Age: {sqlReader[1]}");
                    }
                }  // Dispose SqlDataReader

            } // Dispose SqlConnection

        }
    }
}