namespace SongBook;

public class Logic {


    public static void DisplaySongs(List<Song> songList) {

        foreach(Song song in songList) {
            Console.WriteLine(song.ToString());
        }
    }


    public static Song GenerateSong() {

        List<Song> songList = new();

        Song returnSong = new();
        Console.WriteLine("Record Your song's name");
        returnSong.Name = Console.ReadLine()?.ToUpper();

        Console.WriteLine($"How long in minutes and seconds is {returnSong.Name}?");

        returnSong.Length = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"What genre is {returnSong.Name}?");

        returnSong.Genre = Console.ReadLine()?.ToUpper();

        Console.WriteLine($"Recorded {returnSong.Genre} song {returnSong.Name}.");

        Data.PersistSongs(songList);

        return returnSong;
    }



}