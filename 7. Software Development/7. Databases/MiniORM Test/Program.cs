using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Mini Object Relation Mapping
using MiniORM;

namespace MiniORM_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connection String
            string connectionString = "server=localhost;database=minions;port=3306;user=root;password=root"; 

            // Entity Manager
            var databaseManager = new DatabaseManager(connectionString, true);


            // Table Countries 
            Console.WriteLine("Table Countries:");
            IEnumerable<Country> countries = databaseManager.FindAll<Country>();
            foreach (var country in countries)
            {
                Console.WriteLine(country.Name);
            }

            // Table Minions 
            Console.WriteLine("Table Minions:");
            var minions = databaseManager.FindAll<Minion>();
            // var minions = databaseManager.FindAll<Minion>().("Age >= 18");
            foreach (var minion in minions)
            {
                Console.WriteLine(minion.Name);
            }

        }
    }
}
