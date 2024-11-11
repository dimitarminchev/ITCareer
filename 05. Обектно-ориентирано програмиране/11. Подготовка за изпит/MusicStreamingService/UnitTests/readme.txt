Case=Test_01
input=AddUser mitko 28
End
output="Created User mitko!"

Case=Test_02
input=AddUser mitko 28
AddPlaylist mitko Workout
End
output = "Created User mitko!
Created Playlist Workout for User mitko!"

Case=Test_03
input=AddUser Ivan 20
AddPlaylist Ivan WorkoutHits
AddSongToPlaylist Ivan WorkoutHits BeatIt 240 MichaelJackson Pop Single 10/07/1983
AddSongToPlaylist Ivan WorkoutHits BillieJean 250 MichaelJackson Pop AlbumSong Thriller
End
output="Created User Ivan!
Created Playlist WorkoutHits for User Ivan!
Added song BeatIt to Playlist WorkoutHits!
Added song BillieJean to Playlist WorkoutHits!"

Case=Test_04
input=AddUser Ivan 20
AddPlaylist Ivan WorkoutHits
AddSongToPlaylist Ivan WorkoutHits BeatIt 240 MichaelJackson Pop Single 10/07/1983
AddSongToPlaylist Ivan WorkoutHits BillieJean 250 MichaelJackson Pop AlbumSong Thriller
GetTotalDurationOfPlaylist Ivan WorkoutHits
End
output="Created User Ivan!
Created Playlist WorkoutHits for User Ivan!
Added song BeatIt to Playlist WorkoutHits!
Added song BillieJean to Playlist WorkoutHits!
Total duration of WorkoutHits: 490 seconds"

Case=Test_05
input=AddUser John 30
AddPlaylist John RockHits
AddSongToPlaylist John RockHits Thunderstruck 292 ACDC Rock AlbumSong TheRazorsEdge
AddSongToPlaylist John RockHits EnterSandman 331 Metallica Metal AlbumSong Metallica
AddSongToPlaylist John RockHits HighwayToHell 208 ACDC Rock AlbumSong HighwayToHell
GetTotalDurationOfPlaylist John RockHits
GetSongsByGenreFromPlaylist John RockHits Rock
GetSongsAboveDurationFromPlaylist John RockHits 300
End

output="Created User John!
Created Playlist RockHits for User John!
Added song Thunderstruck to Playlist RockHits!
Added song EnterSandman to Playlist RockHits!
Added song HighwayToHell to Playlist RockHits!
Total duration of RockHits: 831 seconds
Title: Thunderstruck
Duration: 292 seconds
Artist: ACDC
Album: TheRazorsEdge
Title: HighwayToHell
Duration: 208 seconds
Artist: ACDC
Album: HighwayToHell
Title: EnterSandman
Duration: 331 seconds
Artist: Metallica
Album: Metallica"

Case=Test_06
input=AddUser Alice 20
AddPlaylist Alice MyFavorites
AddSongToPlaylist Alice MyFavorites A 200 ArtistName Rock Single 01/01/2021
End

output="Created User Alice!
Created Playlist MyFavorites for User Alice!
Title should be between 2 and 100 characters!"

Case=Test_07
input=AddUser Charlie 12
End

output="User must be at least 13 years old!"