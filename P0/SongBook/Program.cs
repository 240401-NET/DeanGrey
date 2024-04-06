namespace SongBook;

class Program
{
    static void Main(string[] args)
    {
       List<Song> songList = new();

    //    try {
    //     songList = Data.LoadSongs();
    //    }

    int UserInput = 0;

    while (UserInput !=9) {
        Menu.ListMenu();

        UserInput = Menu.UserSelection();

        if (UserInput == 1) {
            songList.Add(Logic.GenerateSong());
        } else if (UserInput == 2) {
            Logic.DisplaySongs(songList);
        } else if (UserInput == 9) {
            Console.WriteLine("Until Next Time");
        } else {
            Console.WriteLine("Pick a Valid Option");
        }


    }

    }
}
