using MySql.Data.MySqlClient;
using System;

namespace MYSQL_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заглавие на конзолното приложение
            Console.WriteLine("MySQL Demo 1.0");
            Console.WriteLine(new string('-', 25));

            // 1. Отваряне на връзка към MySQL база данни
            MySqlConnection dbConn = new MySqlConnection
            (
                "server=localhost;port=3306;user=root;password=root;database=minions"
            );
            dbConn.Open();
            using (dbConn)
            {
                // 2. Създаване на таблица 
                //MySqlCommand command = new MySqlCommand
                //(
                //    "CREATE TABLE minions (id INT, name VARCHAR(50), age INT)", dbConn
                //);
                //command.ExecuteNonQuery();

                // 3. Добавяне на записи в таблицата
                //MySqlCommand command = new MySqlCommand
                //(
                //    "INSERT INTO minions (id, name, age) VALUES ('1', 'Kevin', '15');" +
                //    "INSERT INTO minions (id, name, age) VALUES ('2', 'Bob', '22');" +
                //    "INSERT INTO minions (id, name, age) VALUES ('3', 'Steward', '42');", dbConn
                //);
                //command.ExecuteNonQuery();

                // 4. Извеждане на записите от таблицата
                MySqlCommand command = new MySqlCommand
                (
                    "SELECT name,age FROM minions;", dbConn
                );
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("Name: {0}, Age: {1}", reader[0], reader[1]);
                }
            }
        }
    }
}
