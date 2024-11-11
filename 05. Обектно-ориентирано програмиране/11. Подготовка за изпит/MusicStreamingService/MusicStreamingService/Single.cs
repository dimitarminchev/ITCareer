using System;

public class Single : Song
{
    private DateTime releaseDate;

    public DateTime ReleaseDate
    {
        get
        {
            return releaseDate;
        }
        set
        {
            releaseDate = value;
        }
    }

    public Single(string title, int duration, string artist, string genre, DateTime releaseDate) : base(title, duration, artist, genre)
    {
        ReleaseDate = releaseDate;
    }

    public override string ToString()
    {
        return base.ToString() + Environment.NewLine + $"Release Date: {ReleaseDate.ToString("dd/MM/yyyy")}";
    }
}


