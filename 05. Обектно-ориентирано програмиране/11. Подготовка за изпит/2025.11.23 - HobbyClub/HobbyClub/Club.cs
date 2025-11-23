using System;
using System.Collections.Generic;
using System.Linq;

public class Club
{
    private string name;
    private List<Activity> activities;

    public string Name
    {
        get => name;
        set
        {
            if (value.Length < 2 || value.Length > 40)
                throw new ArgumentException("Name should be between 2 and 40 characters!");
            name = value;
        }
    }

    public Club(string name)
    {
        Name = name;
        activities = new List<Activity>();
    }

    public void AddActivity(Activity activity)
    {
        activities.Add(activity);
    }

    public void AddRate(string title, int rate)
    {
        var act = activities.FirstOrDefault(a => a.Title == title);
        if (act == null)
            throw new ArgumentException("Activity not found!");
        act.AddRating(rate);
    }

    public double AverageRating()
    {
        var rated = activities.Where(a => a.Rating > 0).ToList();
        if (rated.Count == 0) return 0;
        return rated.Average(a => a.Rating);
    }

    public List<Activity> GetActivitiesByLeader(string leader)
    {
        return activities
            .Where(a => a.Leader == leader)
            .OrderByDescending(a => a.Duration)
            .ToList();
    }

    public List<Activity> GetActivitiesBetweenDuration(int from, int to)
    {
        return activities
            .Where(a => a.Duration >= from && a.Duration <= to)
            .OrderByDescending(a => a.Rating)
            .ToList();
    }

    public override string ToString()
    {
        return $"Club {Name}\nTotal Activities: {activities.Count}";
    }
}
