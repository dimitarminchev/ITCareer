using MySql.Data.MySqlClient;
using System;

namespace _02.VilliansNames
{
    class Program
    {
        static void Main(string[] args)
        {
            // Заявка
            var sql = "SELECT villains.name, COUNT(*) as count FROM minionsdb.minionsvillains" +
                        " join villains on minionsvillains.VillainId = villains.id" +
                        " group by minionsvillains.VillainId" +
                        " having count > 1";

            // Изпълнение
            Database minionsdb = new Database();
            using (MySqlDataReader reader = minionsdb.Query(sql))
            {
                while (reader.Read())
                {
                    Console.WriteLine("Name: {0}, MinionsCount: {1}", reader[0], reader[1]);
                }
            }
           
        }
    }
}
