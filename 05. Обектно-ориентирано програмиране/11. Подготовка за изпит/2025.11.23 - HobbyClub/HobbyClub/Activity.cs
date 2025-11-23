using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Activity
{
    private string title;
    private int duration;
    private int level;
    private int intensity;
    private string leader;
    private List<int> ratings;

    public string Title
    {
        get => title;
        set
        {
            if (value.Length < 3 || value.Length > 54)
                throw new ArgumentException("Title should be between 3 and 54 characters!");
            title = value;
        }
    }

    public int Duration
    {
        get => duration;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Duration should be positive!");
            duration = value;
        }
    }

    public int Level
    {
        get => level;
        set
        {
            if (value < 1 || value > 12)
                throw new ArgumentException("Level should be between 1 and 12!");
            level = value;
        }
    }

    public int Intensity
    {
        get => intensity;
        set
        {
            if (value < 1 || value > 3)
                throw new ArgumentException("Intensity should be between 1 and 3!");
            intensity = value;
        }
    }

    public string Leader
    {
        get => leader;
        set
        {
            if (value.Length < 3 || value.Length > 54)
                throw new ArgumentException("Leader should be between 3 and 54 characters!");
            leader = value;
        }
    }

    public Activity(string title, int duration, int level, int intensity, string leader)
    {
        Title = title;
        Duration = duration;
        Level = level;
        Intensity = intensity;
        Leader = leader;
        ratings = new List<int>();
    }

    public void AddRating(int rate)
    {
        if (rate < 1 || rate > 5) return;
        ratings.Add(rate);
    }

    public double Rating
    {
        get
        {
            if (ratings.Count == 0) return 0;
            return ratings.Average();
        }
    }

    public override string ToString()
    {
        return $"Title: {Title} for level {Level} ({Duration} mins.) - intensity {Intensity} led by {Leader} (Rating: {Rating:F2} / 5)";
    }
}
