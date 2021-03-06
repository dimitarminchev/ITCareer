using System;

namespace _05.ChangeRegister
{
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            // Towns
            var towns = new Dictionary<int, string>();

            // Input
            Console.Write("Enter country: ");
            var countryName = Console.ReadLine();

            // Process
            using (var conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=minions;Integrated Security=true"))
            {
                conn.Open();

                // Find Country Id
                SqlCommand sql = new SqlCommand
                (
                    "SELECT TOP 1 countries.id FROM countries " +
                   $"WHERE countries.name = @countryName", conn
                );
                sql.Parameters.AddWithValue("@countryName", countryName);
                int countryId = int.Parse(sql.ExecuteScalar().ToString());

                // Find All Towns for selected Country
                sql = new SqlCommand
                (
                    "SELECT towns.id, towns.name FROM towns" +
                   $" WHERE towns.CountryCode = @countryId", conn
                );
                sql.Parameters.AddWithValue("@countryId", countryId);
                var reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    towns.Add(int.Parse(reader[0].ToString()), reader[1].ToString().ToUpper());
                }
                reader.Close();

                // Update the Namesof all Towns for selected Country
                foreach (var town in towns)
                {
                    sql = new SqlCommand("UPDATE towns SET name = @name WHERE id=@id", conn);
                    sql.Parameters.AddWithValue("@name", town.Value);
                    sql.Parameters.AddWithValue("@id", town.Key);
                    sql.ExecuteNonQuery();
                }

                // Finally print some information for the user
                if (towns.Count() > 0)
                {
                    Console.WriteLine($"{towns.Count()} town names were affected.");
                    Console.WriteLine("[" + string.Join(", ", towns.Values) + "]");
                }
                else
                {
                    Console.WriteLine("No town names were affected.");
                }
            }
        }
    }
}
