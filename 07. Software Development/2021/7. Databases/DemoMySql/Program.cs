using System;

namespace DemoMySql
{
    // Oracle MySQL Server
    using MySql.Data.MySqlClient;

    class Program
    {
        static void Main(string[] args)
        {
            // Заглавие на конзолното приложение
            Console.WriteLine("Oracle MySQL Server:");
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
                MySqlCommand command1 = new MySqlCommand
                (
                    "CREATE TABLE minions (id INT, name VARCHAR(50), age INT)", dbConn
                );
                command1.ExecuteNonQuery();

                // 3. Добавяне на записи в таблицата
                MySqlCommand command2 = new MySqlCommand
                (
                    "INSERT INTO minions (id, name, age) VALUES ('1', 'Kevin', '15');" +
                    "INSERT INTO minions (id, name, age) VALUES ('2', 'Bob', '22');" +
                    "INSERT INTO minions (id, name, age) VALUES ('3', 'Steward', '42');", dbConn
                );
                command2.ExecuteNonQuery();

                // 4. Извеждане на записите от таблицата
                MySqlCommand command3 = new MySqlCommand
                (
                    "SELECT name,age FROM minions;", dbConn
                );
                MySqlDataReader reader = command3.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("Name: {0}, Age: {1}", reader[0], reader[1]);
                }
            }
        }
    }
}
