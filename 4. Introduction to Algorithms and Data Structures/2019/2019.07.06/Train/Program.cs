using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        // Trains
        private static Deque<Train> trains = new Deque<Train>();
        private static Stack<Train> history = new Stack<Train>();

        private static void Add(int number, string name, string type, int cars)
        {
            if (type == "F")
            {
                //Add freight trains to back
                trains.AddBack(new Train(number, name, type, cars));
            }
            else
            {
                trains.AddFront(new Train(number, name, type, cars));
            }
        }
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
        private static void Next()
        {
            if (trains.Count > 0)
            {
                Train frontTrain = trains.GetFront();
                Train backTrain = trains.GetBack();
                if (backTrain != null && backTrain.Type == "F" && backTrain.Cars > 15)
                {
                    var item = backTrain.ToString();
                    Console.WriteLine(item);
                }
                else if (frontTrain != null && frontTrain.Type == "P")
                {
                    var item = frontTrain.ToString();
                    Console.WriteLine(item);
                }
                else if (backTrain != null && backTrain.Type == "F")
                {
                    var item = backTrain.ToString();
                    Console.WriteLine(item);
                }
            }
        }

        private static void History()
        {
            foreach (var train in history)
            {
                Console.WriteLine(train.ToString());
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
