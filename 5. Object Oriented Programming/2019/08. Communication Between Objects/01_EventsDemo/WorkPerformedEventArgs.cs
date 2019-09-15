using System;

public class WorkPerformedEventArgs : EventArgs
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private int hours;

    public int Hours
    {
        get { return hours; }
        set { hours = value; }
    }

    public WorkPerformedEventArgs(string name, int hours)
    {
        this.name = name;
        this.hours = hours;
    }
}

