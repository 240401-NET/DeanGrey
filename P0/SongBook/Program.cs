namespace SongBook;



class Program {
    static void Main(string[] args) {

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
            Console.WriteLine("Enter the position of the song to remove:");
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


//Remove Option Explained

// Console.ReadLine(): This reads a line of text from the standard input (typically, the console) and returns it as a string.
// int.TryParse(): This method attempts to convert the provided string representation of a number to its integer equivalent. It returns a boolean value indicating whether the conversion succeeded or failed.
// out int indexToRemove: This declares a new variable named indexToRemove of type int. The out keyword indicates that this variable will be assigned a value by the TryParse method.
// So, the entire line reads a line of text from the console, attempts to parse it as an integer, and if successful, assigns the parsed integer value to the variable indexToRemove. The if statement checks if the parsing was successful (TryParse returns true). If parsing succeeds, the code inside the if block will execute, allowing the program to proceed with removing the song at the specified position. If parsing fails (e.g., if the user enters non-numeric input), the if block will not execute, and the program will prompt the user again for a valid input.