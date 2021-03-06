using System;

namespace _06.RemoveVillian
{
    using System.Data.SqlClient;

    class Program
    {
        static void Main(string[] args)
        {
            // Input
            Console.Write("Enter villain id: ");
            int villainId = int.Parse(Console.ReadLine());

            // Process
            using (var conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=minions;Integrated Security=true"))
            {
                conn.Open();

                // 1. Execute query to find Villain by Id
                SqlCommand comm = new SqlCommand( $"SELECT count(*) FROM villains WHERE villains.id = @villainId", conn);
                comm.Parameters.AddWithValue("@villainId", villainId);

                // 2. Check if the villain exists
                bool existsVillain = int.Parse(comm.ExecuteScalar().ToString()) > 0;
                if (existsVillain == false)
                {
                    Console.WriteLine("No such villain was found.");
                }
                else
                {
                    // Get villain's name
                    comm = new SqlCommand("SELECT name FROM villains WHERE villains.id = @villainId", conn);
                    comm.Parameters.AddWithValue("@villainId", villainId);
                    string villainName = comm.ExecuteScalar().ToString();

                    // Release minions
                    comm = new SqlCommand("DELETE FROM minionsvillains WHERE villainId = @villainId;", conn);
                    comm.Parameters.AddWithValue("@villainId", villainId);
                    int releasedMinions = comm.ExecuteNonQuery();

                    // Remove villain from database
                    comm = new SqlCommand("DELETE FROM villains WHERE id=@villainId ", conn);
                    comm.Parameters.AddWithValue("@villainId", villainId);
                    comm.ExecuteNonQuery();

                    // Check if transaction is successful
                    if (releasedMinions > 0)
                    {
                        Console.WriteLine($"{villainName} was deleted.");
                        Console.WriteLine($"{releasedMinions} minions were released.");
                    }
                    else
                    {
                        Console.WriteLine("No changes were made.");
                    }

                }
            }
        }
    }
}
