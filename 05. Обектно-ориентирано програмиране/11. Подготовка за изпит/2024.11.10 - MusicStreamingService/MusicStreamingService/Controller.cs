using System;
using System.Collections.Generic;
using System.Linq;

public class Controller
{
    private Dictionary<string, User> users;

    public Controller()
    {
        users = new Dictionary<string, User>();
    }

    public string AddUser(List<string> args)
    {
        string username = args[0];
        int age = int.Parse(args[1]);

        users.Add(username, new User(username, age));

        return $"Created User {username}!";
    }

    public string AddPlaylist(List<string> args)
    {
        string username = args[0];
        string title = args[1];

        users[username].AddPlaylist(new Playlist(title));

        return $"Created Playlist {title} for User {username}!";
    }

    public string AddSongToPlaylist(List<string> args)
    {
        string username = args[0];
        string playlistTitle = args[1];
        string songTitle = args[2];
        int duration = int.Parse(args[3]);
        string artist = args[4];
        string genre = args[5];
        string type = args[6];

        if (type=="Single")
        {
            DateTime releaseDate = DateTime.Parse(args[7]);
            users[username].GetPlaylistByTitle(playlistTitle).AddSong(new Single(songTitle, duration, artist, genre, releaseDate));
        }
        else if (type == "AlbumSong")
        {
            string albumName = args[7];
            users[username].GetPlaylistByTitle(playlistTitle).AddSong(new AlbumSong(songTitle, duration, artist, genre, albumName));
        }

        return $"Added song {songTitle} to Playlist {playlistTitle}!";
    }

    public string GetTotalDurationOfPlaylist(List<string> args)
    {
        string username = args[0];
        string playlistTitle = args[1];

        return $"Total duration of {playlistTitle}: {users[username].GetPlaylistByTitle(playlistTitle).songs.Sum(x => x.Duration)} seconds";
    }

    public string GetSongsByArtistFromPlaylist(List<string> args)
    {
        string username = args[0];
        string playlistTitle = args[1];
        string artist = args[2];

        return string.Join(Environment.NewLine, users[username].GetPlaylistByTitle(playlistTitle).GetSongsByArtist(artist));
    }

    public string GetSongsByGenreFromPlaylist(List<string> args)
    {
        string username = args[0];
        string playlistTitle = args[1];
        string genre = args[2];

        return string.Join(Environment.NewLine, users[username].GetPlaylistByTitle(playlistTitle).GetSongsByGenre(genre));
    }

    public string GetSongsAboveDurationFromPlaylist(List<string> args)
    {
        string username = args[0];
        string playlistTitle = args[1];
        int duration = int.Parse(args[2]);

        return string.Join(Environment.NewLine, users[username].GetPlaylistByTitle(playlistTitle).GetSongsAboveDuration(duration));
    }
}
