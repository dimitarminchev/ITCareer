using System;
using System.Collections.Generic;
using System.Text;

public class User
{
    private string username;

    public string Username
    {
        get
        {
            return username;
        }
        set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("Username should be between 3 and 30 characters!");
            }
            else username = value;
        }
    }

    private int age;

    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value < 13)
            {
                throw new ArgumentException("User must be at least 13 years old!");
            }
            else age = value;
        }
    }

    public List<Playlist> playlists;

    public User(string username, int age)
    {
        Username = username;
        Age = age;
        playlists = new List<Playlist>();
    }

    public void AddPlaylist(Playlist playlist)
    {
        playlists.Add(playlist);
    }

    public Playlist GetPlaylistByTitle(string title)
    {
        return playlists.Find(x => x.Title == title);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Username: {Username}");
        sb.AppendLine($"Age: {Age}");
        sb.Append($"Total Playlists: {playlists.Count}");
        return sb.ToString().TrimEnd();
    }
}
