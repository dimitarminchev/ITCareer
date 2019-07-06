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

        // Добавяне на играч със зарове
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
            players[player].PrintCurrentPairSum();
        }

        // Текущо състояние на всички двойки на даден играч
        public static void CurrentState(string player)
        {
            players[player].PrintCurrentState();
        }
        
        // Победител
        public static void Winner()
        {
            string winner = String.Empty;
            int min = players.FirstOrDefault().Value.SumIntervalPairs().Difference();            
            foreach (var player in players)
            {
                var temp = player.Value.SumIntervalPairs().Difference();
                if (temp <= min)
                {
                    min = temp;
                    winner = player.Key;
                }
            }
            Console.WriteLine($"{winner} wins the game!");
        }

        // Статистика
        public static void CurrentStanding()
        {
            var list = players.OrderByDescending(x => x.Value.SumIntervalPairs().Difference()).ToList();
            foreach (var player in list)
            {
                Console.Write(player.Key + " - ");
                player.Value.PrintCurrentState();
            }
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
                    case "CurrentState":
                        {
                            CurrentState(line[1]);
                            break;
                        }
                    case "CurrentPairSum":
                        {
                            CurrentPairSum(line[1]);
                            break;
                        }
                    case "Winner":
                        {
                            Winner();
                            break;
                        }
                    case "CurrentStanding":
                        {
                            CurrentStanding();
                            break;
                        }
                }
                line = System.Console.ReadLine().Split().ToArray();
            }
        }
    }
}
