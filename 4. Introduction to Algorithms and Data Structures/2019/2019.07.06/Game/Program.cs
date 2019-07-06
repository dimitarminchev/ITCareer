using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        // Капацитет
        public static int capacity = 0;

        // Речник на играчите
        public static Dictionary<string, CapacityList> players = new Dictionary<string, CapacityList>();

        // Зарове
        public static void Dice(string player, int number1, int number2)
        {
            if (players.ContainsKey(player))
            {
                // Добавяне на числата към съществуващ играч
                players[player].Add(new Pair(number1, number2));
            }
            else
            {
                // Добавяне на числата към нов играч
                var list = new CapacityList(capacity);
                list.Add(new Pair(number1, number2));
                players.Add(player, list);
            }
        }

        // Сума на двойките за даден играч
        public static void CurrentPairSum(string player)
        {
            players[player].PrintCurrentState();
        }

        // Game
        static void Main(string[] args)
        {
            capacity = int.Parse(System.Console.ReadLine());

            var line = System.Console.ReadLine().Split().ToArray();
            while (line[0] != "End")
            {
                switch (line[0])
                {
                    case "Dice":
                        {
                            Dice(line[1], int.Parse(line[2]), int.Parse(line[3]));
                            break;
                        }
                    case "CurrentPairSum":
                        {
                            CurrentPairSum(line[1]);
                            break;
                        }
                }
                line = System.Console.ReadLine().Split().ToArray();
            }
        }
    }
}
