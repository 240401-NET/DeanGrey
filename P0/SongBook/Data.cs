using System.Text.Json;

namespace SongBook;


class Data {
    public static List<Song> LoadSongs(){

        try{
            string filePath = "songList.json";
            string jsonSongs = File.ReadAllText(filePath);

            List<Song>? songs = JsonSerializer.Deserialize<List<Song>>(jsonSongs);
            if(songs is null) {
                return new List<Song>();   
            }
            else {
                return songs;
            }

        }catch(Exception e){
            Console.WriteLine(e.Message + "Out of Tune! Unable to Generate");
            throw;
        }

    }

    public static void PersistSongs(List<Song> songs){

       
        string jsonSongs = JsonSerializer.Serialize(songs);
        string filePath = "songList.json";

        File.WriteAllText(filePath, jsonSongs);

    }

}