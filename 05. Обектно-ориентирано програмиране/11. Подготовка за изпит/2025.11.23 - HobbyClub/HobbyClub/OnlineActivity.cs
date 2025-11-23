using System;

public class OnlineActivity : Activity
{
    private string platform;

    public string Platform
    {
        get => platform;
        set
        {
            if (value.Length < 3 || value.Length > 30)
                throw new ArgumentException("Platform should be between 3 and 30 characters!");
            platform = value;
        }
    }

    public OnlineActivity(string title, int duration, int level, int intensity, string leader, string platform)
        : base(title, duration, level, intensity, leader)
    {
        Platform = platform;
    }

    public override string ToString()
    {
        return base.ToString() + $" @ Online: {Platform}";
    }
}
