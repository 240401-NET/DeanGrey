namespace SongBook;

class Program
{
    static void Main(string[] args)
    {
       List<Song> songList = new();

     try {
            songList = Data.LoadSongs();
        }
        catch(Exception e) {
            Console.WriteLine(e.Message + "File not generated, first time execution!");
        }

    int UserInput = 0;

    while (UserInput !=9) {
        Menu.ListMenu();

        UserInput = Menu.UserSelection();

        if (UserInput == 1) {
            songList.Add(Logic.GenerateSong());
            Data.PersistSongs(songList);
        } else if (UserInput == 2) {
            Console.WriteLine("~~~~~~~~~~~~~~~~");
            Console.WriteLine("WELCOME TO YOUR SONGBOOK!\n");
            Logic.DisplaySongs(songList);
        } else if (UserInput == 3) {
       Console.WriteLine("Enter the index of the song to remove:");
    if (int.TryParse(Console.ReadLine(), out int indexToRemove)) {
        indexToRemove--;
        if (indexToRemove >= 0 && indexToRemove < songList.Count) {
            songList.RemoveAt(indexToRemove);
            Data.PersistSongs(songList); 
        } else {
            Console.WriteLine("Invalid song index.");
        }
    } else {
        Console.WriteLine("No song in that position, please re-enter");
    }
        } else if (UserInput == 9) {
            Console.WriteLine("And on that Note...");
        } else {
            Console.WriteLine("Oops! Try Again");
        }


    }

    }
}
