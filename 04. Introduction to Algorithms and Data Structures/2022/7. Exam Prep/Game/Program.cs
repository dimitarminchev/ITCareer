namespace Game
{
    public class Program
    {
        // Капацитет
        public static int capacity = 0;

        // Речник на играчите
        public static Dictionary<string, CapacityList> players = new Dictionary<string, CapacityList>();

        /// <summary>
        /// Добавяне на играч със зарове
        /// </summary>
        public static void Dice(string player, int dice1, int dice2)
        {
            if (players.ContainsKey(player))
            {
                // Добавяне към съществуваш играч
                players[player].Add(new Pair(dice1, dice2));
            }
            else 
            {
                // Добавяне към нов играч
                var list = new CapacityList(capacity);
                list.Add(new Pair(dice1, dice2));
                players.Add(player, list);
            }
        }

        /// <summary>
        /// Сума на двойките на даден играч
        /// </summary>
        public static void CurrentPairSum(string player)
        {
            players[player].PrintCurrentStateSum();
        }

        /// <summary>
        /// Текущо състояние на всички двойки на играча
        /// </summary>
        public static void CurrentState(string player)
        {
            players[player].PrintCurrentState();
        }

        /// <summary>
        /// Обявяване на победителя
        /// </summary>
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

        /// <summary>
        /// Статистическа информация
        /// </summary>
        public static void CurrentStanding()
        {
            var list = players.OrderByDescending(x => x.Value.SumIntervalPairs().Difference()).ToList();
            foreach (var player in list)
            {
                Console.Write($"{player.Key} - ");
                player.Value.PrintCurrentState();
            }
        }

        /// <summary>
        /// Главна програма
        /// </summary>
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
