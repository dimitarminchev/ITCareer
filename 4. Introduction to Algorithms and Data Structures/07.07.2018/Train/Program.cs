using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Program
    {
        private static Deque<Train> trains = new Deque<Train>();
        private static List<string> outputLines = new List<string>();
        // TODO: add history functionality

        static void Main(string[] args)
        {
            string[] command;
            do
            {
                command = Console.ReadLine().Split(' ').ToArray();
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
            Console.WriteLine(string.Join("\n",outputLines));
        }

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

        private static void Travel()
        {
            if (trains.Count > 0)
            {
                Train frontTrain = trains.GetFront();
                Train backTrain = trains.GetBack();
                if (backTrain != null && backTrain.Type == "F" && backTrain.Cars > 15)
                {
                    // Console.WriteLine(trains.RemoveBack());
                    outputLines.Add(trains.RemoveBack() + "");
                }
                else if (frontTrain != null && frontTrain.Type == "P")
                {
                    //  Console.WriteLine(trains.RemoveFront());
                    outputLines.Add(trains.RemoveFront() + "");
                }
                else if (backTrain != null && backTrain.Type == "F")
                {
                    //  Console.WriteLine(trains.RemoveBack());
                    outputLines.Add(trains.RemoveBack() + "");
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
                    // Console.WriteLine(backTrain);
                    outputLines.Add(backTrain + "");
                }
                else if (frontTrain != null && frontTrain.Type == "P")
                {
                    // Console.WriteLine(frontTrain);
                    outputLines.Add(frontTrain + "");
                }
                else if (backTrain != null && backTrain.Type == "F")
                {
                    //Console.WriteLine(backTrain);
                    outputLines.Add(backTrain + "");
                }
            }
        }

        private static void History()
        {
            foreach (var item in trains.GetHistory())
            {
                // Console.WriteLine(item);
                outputLines.Add(item + "");
            }
        }
    }
}
