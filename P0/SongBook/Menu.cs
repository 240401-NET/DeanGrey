namespace SongBook;


public class Menu {

public static void ListMenu() {
    Console.WriteLine("1. Record a New Song");
    Console.WriteLine("2. View SongBook");
    Console.WriteLine("3. Remove a Record");
    Console.WriteLine("  Press 9 to exit");
}
    public static int UserSelection()
    {
        
        try {
            return Convert.ToInt32(Console.ReadLine());
        } catch(Exception e) {
            Console.WriteLine(e.Message + "Invalid Selection");
            return -1;
        }
         
    }

}



