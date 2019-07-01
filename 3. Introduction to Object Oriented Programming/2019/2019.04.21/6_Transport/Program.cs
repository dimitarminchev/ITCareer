using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Transport
{
    class Program
    {
        static void Main(string[] args)
        {
/*
BigTruck=22;Truck=15;LittleTruck=7
Rock=18;Silk=12;Water=3
BigTruck Rock
Truck Water
Truck Water
Truck Rock
LittleTruck Water
LittleTruck Water
END
 */
            // Trucks
            var trucks = new List<Truck>();
            var cmd = Console.ReadLine().Split(';');
            foreach (var item in cmd)
            {
                var next = item.Split('=');
                try
                {
                    trucks.Add
                    (
                        new Truck(next[0], int.Parse(next[1]))
                    );
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }

            // Freights
            var freights = new List<Freight>();
            cmd = Console.ReadLine().Split(';');
            foreach (var item in cmd)
            {
                var next = item.Split('=');
                try
                {
                    freights.Add
                    (
                        new Freight(next[0], float.Parse(next[1]))
                    );
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }

            // Input
            cmd = Console.ReadLine().Split().ToArray();
            while (cmd[0] != "END")
            {
                try
                {
                    trucks.FirstOrDefault(item => item.Name == cmd[0]).Add
                    (
                        freights.FirstOrDefault(item => item.Name == cmd[1])
                    );
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
                cmd = Console.ReadLine().Split().ToArray();
            }

            // Print
            trucks.ForEach(item => Console.WriteLine(item));
        }
    }
}
