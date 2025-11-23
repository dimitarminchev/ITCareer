using System;

public class OnsiteActivity : Activity
{
    private string location;

    public string Location
    {
        get => location;
        set
        {
            if (value.Length < 3 || value.Length > 54)
                throw new ArgumentException("Leader should be between 3 and 54 characters!");
            location = value;
        }
    }

    public OnsiteActivity(string title, int duration, int level, int intensity, string leader, string location)
        : base(title, duration, level, intensity, leader)
    {
        Location = location;
    }

    public override string ToString()
    {
        return base.ToString() + $" @ Onsite: {Location}";
    }
}
