using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Playlist
{
    private string title;

    public string Title
    {
        get
        {
            return title;
        }
        set
        {
            if (value.Length < 3 || value.Length > 50)
            {
                throw new ArgumentException("Playlist title should be between 3 and 50 characters!");
            }
            else title = value;
        }
    }

    public List<Song> songs;

    public Playlist(string title)
    {
        Title = title;
        songs = new List<Song>();
    }

    public void AddSong(Song song)
    {
        songs.Add(song);
    }

    public int TotalDuration()
    {
        return songs.Sum(x => x.Duration);
    }

    public List<Song> GetSongsByArtist(string artist)
    {
        return songs.Where(x => x.Artist == artist).OrderBy(x => x.Title).ToList();
    }

    public List<Song> GetSongsByGenre(string genre)
    {
        return songs.Where(x => x.Genre == genre).OrderBy(x => x.Title).ToList();
    }

    public List<Song> GetSongsAboveDuration(int duration)
    {
        return songs.Where(x => x.Duration > duration).OrderByDescending(x => x.Duration).ToList();
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Playlist: {Title}");
        sb.Append($"Total Songs: {songs.Count}");
        return sb.ToString().TrimEnd();
    }
}
