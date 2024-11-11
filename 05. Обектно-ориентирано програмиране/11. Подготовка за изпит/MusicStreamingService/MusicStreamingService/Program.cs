using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        Controller controller = new Controller();
        bool isRunning = true;
        while (isRunning)
        {
            string[] splittedInput = Console.ReadLine().Split();

            string command = splittedInput[0];
            List<string> arguments = splittedInput.Skip(1).ToList();
            string result = "";

            try
            {
                switch (command)
                {
                    case "AddUser":
                        result = controller.AddUser(arguments);
                        break;
                    case "AddPlaylist":
                        result = controller.AddPlaylist(arguments);
                        break;
                    case "AddSongToPlaylist":
                        result = controller.AddSongToPlaylist(arguments);
                        break;
                    case "GetTotalDurationOfPlaylist":
                        result = controller.GetTotalDurationOfPlaylist(arguments);
                        break;
                    case "GetSongsByArtistFromPlaylist":
                        result = controller.GetSongsByArtistFromPlaylist(arguments);
                        break;
                    case "GetSongsByGenreFromPlaylist":
                        result = controller.GetSongsByGenreFromPlaylist(arguments);
                        break;
                    case "GetSongsAboveDurationFromPlaylist":
                        result = controller.GetSongsAboveDurationFromPlaylist(arguments);
                        break;
                    case "End":
                        isRunning = false;
                        break;
                    default:
                        result = "Invalid command";
                        break;
                }

                if (!isRunning) break; 

                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }
    }
}
