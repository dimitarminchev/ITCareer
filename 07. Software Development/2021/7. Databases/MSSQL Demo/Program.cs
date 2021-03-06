using System;
using System.Data.SqlClient;

namespace MSSQL_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Отваряне на връзка към база данни
            SqlConnection dbConn = new SqlConnection
            (
                "Server=(localdb)\\ProjectsV13;" +
                "Database=minions;Integrated Security=true"
             );
            dbConn.Open();
            using (dbConn)
            {
                // 2. Създаване на таблица 
                //SqlCommand command = new SqlCommand
                //(
                //    "CREATE TABLE minions (id INT, name VARCHAR(50), age INT)", dbConn
                //);
                //command.ExecuteNonQuery();

                // 3. Добавяне на записи в таблицата
                //SqlCommand command = new SqlCommand
                //(
                //    "INSERT INTO minions (id, name, age) VALUES ('1', 'Kevin', '15');" +
                //    "INSERT INTO minions (id, name, age) VALUES ('2', 'Bob', '22');" +
                //    "INSERT INTO minions (id, name, age) VALUES ('3', 'Steward', '42');",dbConn
                //);
                //command.ExecuteNonQuery();

                // 4. Извеждане на записите от таблицата
                SqlCommand command = new SqlCommand
                (
                    "SELECT name,age FROM minions;", dbConn
                );
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("Name: {0}, Age: {1}", reader[0], reader[1]);
                }
            }
        }
    }
}
