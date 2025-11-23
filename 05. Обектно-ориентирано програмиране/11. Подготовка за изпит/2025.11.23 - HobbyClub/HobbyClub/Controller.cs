using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Controller
{
    private readonly Dictionary<string, Club> clubs;

    public Controller()
    {
        clubs = new Dictionary<string, Club>();
    }

    public string AddClub(List<string> args)
    {
        string name = args[0];
        if (clubs.ContainsKey(name))
            return "Club already exists!";

        Club club = new Club(name);
        clubs.Add(name, club);
        return $"Created Club {name}!";
    }

    public string AddActivity(List<string> args)
    {
        string clubName = args[0];
        string title = args[1];
        int duration = int.Parse(args[2]);
        int level = int.Parse(args[3]);
        int intensity = int.Parse(args[4]);
        string leader = args[5];
        string type = args[6];

        Activity activity;
        if (type == "online")
        {
            string platform = args[7];
            activity = new OnlineActivity(title, duration, level, intensity, leader, platform);
        }
        else
        {
            string location = args[7];
            activity = new OnsiteActivity(title, duration, level, intensity, leader, location);
        }

        clubs[clubName].AddActivity(activity);
        return $"Created Activity {title} in Club {clubName}!";
    }

    public string RateActivity(List<string> args)
    {
        string clubName = args[0];
        string title = args[1];
        int rate = int.Parse(args[2]);

        clubs[clubName].AddRate(title, rate);
        return $"Rated {title} with {rate} rate.";
    }

    public string GetAverageRating(List<string> args)
    {
        string clubName = args[0];
        double avg = clubs[clubName].AverageRating();
        return $"The average rating is: {avg:F2}";
    }

    public string GetActivitiesByLeader(List<string> args)
    {
        string clubName = args[0];
        string leader = args[1];
        var acts = clubs[clubName].GetActivitiesByLeader(leader);
        if (acts.Count == 0) return string.Empty;
        return string.Join("\n", acts.Select(a => a.ToString()));
    }

    public string GetActivitiesBetweenDuration(List<string> args)
    {
        string clubName = args[0];
        int from = int.Parse(args[1]);
        int to = int.Parse(args[2]);
        var acts = clubs[clubName].GetActivitiesBetweenDuration(from, to);
        if (acts.Count == 0) return string.Empty;
        return string.Join("\n", acts.Select(a => a.ToString()));
    }
}
