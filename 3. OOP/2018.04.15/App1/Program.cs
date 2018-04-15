using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            int laps = int.Parse(Console.ReadLine());
            int currentLap = 0;
            int trackLength = int.Parse(Console.ReadLine());
            RaceTower rt = new RaceTower();
            rt.SetTrackInfo(laps, trackLength);
            while (laps >= currentLap)
            {
                List<string> command = Console.ReadLine().Split(' ').ToList();
                switch (command[0])
                {
                    case "RegisterDriver":
                        rt.RegisterDriver(command);
                        break;
                    case "CompleteLaps":
                        {
                            currentLap += int.Parse(command[1]);
                            rt.CompleteLaps(command);
                            break;
                        }
                    case "Box":
                        rt.DriverBoxes(command);
                        break;
                    case "Leaderboard":
                        Console.WriteLine(rt.GetLeaderboard());
                        break;
                    case "ChangeWeather":
                        rt.ChangeWeather(command);
                        break;
                }

            }
        }
    }
 }
