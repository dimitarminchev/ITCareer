using System;
using System.Collections.Generic;
using System.Linq;

namespace TrainsSkeleton {
    internal class Program {
        static Deque<Train> trains = new Deque<Train>();
        static List<string> list = new List<string>();

        private static void Add(int number, string name, string type, int cars) {
            if (type == "F")
                trains.AddBack(new Train(number, name, type, cars));
            else trains.AddFront(new Train(number, name, type, cars));
        }

        static void Travel() {
            if (trains.Count > 0) {
                Train frontTrain = trains.GetFront();
                Train backTrain = trains.GetBack();
                if (backTrain != null && backTrain.Type == "F" && backTrain.Cars > 15) {
                    list.Add(trains.RemoveBack().ToString());
                    Console.WriteLine(list.Last());
                }
                else if (frontTrain != null && frontTrain.Type == "P") {
                    list.Add(trains.RemoveFront().ToString());
                    Console.WriteLine(list.Last());
                }
                else if (backTrain != null && backTrain.Type == "F") {
                    list.Add(trains.RemoveBack().ToString());
                    Console.WriteLine(list.Last());
                }
            }
        }

        static void Next() {
            if (trains.Count > 0) {
                Train frontTrain = trains.GetFront();
                Train backTrain = trains.GetBack();
                if (backTrain != null && backTrain.Type == "F" && backTrain.Cars > 15)
                    Console.WriteLine(backTrain);
                else if (frontTrain != null && frontTrain.Type == "P")
                    Console.WriteLine(frontTrain);
                else if (backTrain != null && backTrain.Type == "F")
                    Console.WriteLine(backTrain);
            }
        }

        static void History() {
            for (int i = list.Count - 1; i >= 0; i--)
                Console.WriteLine(list[i]);
        }

        static void Main() {
            string[] command;
            do {
                command = Console.ReadLine().Split(' ');
                switch (command[0]) {
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