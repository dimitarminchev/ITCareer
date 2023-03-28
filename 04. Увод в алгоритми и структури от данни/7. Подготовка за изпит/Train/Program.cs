namespace Train
{
    public class Program
    {
        private static Deque<Train> trains = new Deque<Train>();
        private static Stack<Train> history = new Stack<Train>();

        /// <summary>
        /// Добавяне на влак
        /// </summary>
        private static void Add(int number, string name, string type, int cars)
        {
            if (type == "F")
            {
                // Add freight trains to back
                trains.AddBack(new Train(number, name, type, cars));
            }
            else
            {
                trains.AddFront(new Train(number, name, type, cars));
            }
        }

        /// <summary>
        /// Отпътуване на следващия по ред влак
        /// </summary>
        private static void Travel()
        {
            if (trains.Count > 0)
            {

                Train frontTrain = trains.GetFront();
                Train backTrain = trains.GetBack();
                if (backTrain != null && backTrain.Type == "F" && backTrain.Cars > 15)
                {
                    var train = trains.RemoveBack();
                    history.Push(train);
                    Console.WriteLine(train.ToString());
                }
                else if (frontTrain != null && frontTrain.Type == "P")
                {
                    var train = trains.RemoveFront();
                    history.Push(train);
                    Console.WriteLine(train.ToString());
                }
                else if (backTrain != null && backTrain.Type == "F")
                {
                    var train = trains.RemoveBack();
                    history.Push(train);
                    Console.WriteLine(train.ToString());
                }
            }
        }

        /// <summary>
        ///  Следващ влак
        /// </summary>
        private static void Next()
        {
            if (trains.Count > 0)
            {

                Train frontTrain = trains.GetFront();
                Train backTrain = trains.GetBack();
                if (backTrain != null && backTrain.Type == "F" && backTrain.Cars > 15)
                {
                    Console.WriteLine(backTrain.ToString());
                }
                else if (frontTrain != null && frontTrain.Type == "P")
                {
                    Console.WriteLine(frontTrain.ToString());
                }
                else if (backTrain != null && backTrain.Type == "F")
                {
                    Console.WriteLine(backTrain.ToString());
                }
            }
        }

        /// <summary>
        /// Информация за преминалите влакове
        /// </summary>
        private static void History()
        {
            foreach (var item in history)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static void Main(string[] args)
        {

            string[] command;
            do
            {
                command = System.Console.ReadLine().Split(' ').ToArray();
                switch (command[0])
                {
                    case "Add":
                        Add(int.Parse(command[1]), command[2], command[3], int.Parse(command[4]));
                        break;
                    case "Travel":
                        Travel();
                        break;
                    case "Next":
                        Next();
                        break;
                    case "History":
                        History();
                        break;
                }
            } while (command[0] != "End");

        }
    }
}
