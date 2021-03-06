using System;

namespace DemoMsSql
{
    // Microsoft SQL Server
    using System.Data.SqlClient;

    class Program
    {
        static void Main(string[] args)
        {
            // Заглавие на конзолното приложение
            Console.WriteLine("Microsoft SQL Server:");
            Console.WriteLine(new string('-',25));

            // 1. Отваряне на връзка към MSSQL база данни
            SqlConnection dbConn = new SqlConnection
            (
                "Server=(localdb)\\MSSQLLocalDB;" +
                "Database=minions;Integrated Security=true"
             );
            dbConn.Open();
            using (dbConn)
            {
                // 2. Създаване на таблица 
                SqlCommand command1 = new SqlCommand
                (
                    "CREATE TABLE minions (id INT, name VARCHAR(50), age INT)", dbConn
                );
                command1.ExecuteNonQuery();

                // 3. Добавяне на записи в таблицата
                SqlCommand command2 = new SqlCommand
                (
                    "INSERT INTO minions (id, name, age) VALUES ('1', 'Kevin', '15');" +
                    "INSERT INTO minions (id, name, age) VALUES ('2', 'Bob', '22');" +
                    "INSERT INTO minions (id, name, age) VALUES ('3', 'Steward', '42');", dbConn
                );
                command2.ExecuteNonQuery();

                // 4. Извеждане на записите от таблицата
                SqlCommand command3 = new SqlCommand
                (
                    "SELECT name,age FROM minions;", dbConn
                );
                SqlDataReader reader = command3.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("Name: {0}, Age: {1}", reader[0], reader[1]);
                }
            }
        }
    }
}
