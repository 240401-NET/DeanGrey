namespace SongBook;

class Logic {


    public static void DisplaySongs(List<Song> songList) {

        foreach(Song song in songList) {
            Console.WriteLine(song.ToString());
        }
    }


    public static Song GenerateSong() {

        Song returnSong = new();
        Console.WriteLine("Record Your song's name");
        returnSong.Name = Console.ReadLine();

        Console.WriteLine($"How long in minutes and seconds is {returnSong.Name}?");

        returnSong.Length = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"What genre is {returnSong.Name}?");

        returnSong.Genre = Console.ReadLine();

        Console.WriteLine($"Recorded {returnSong.Genre} song {returnSong.Name}.");

        return returnSong;
    }







}