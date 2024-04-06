using System.Text.Json;

namespace SongBook;

class Data 
{

    //
    //Read the file
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
            // characters is assigned the deserialized list of characters from the jsonCharacters string. ~ Ricardo PenaMcKnight
            // ?? is Null Coalescing Operator
            // return JsonSerializer.Deserialize<List<Character>>(jsonCharacters) ?? new List<Character>();
            
            // foreach(Character character in characters){
            //     Console.WriteLine(character);
            // }

        }catch(Exception e){
            Console.WriteLine(e.Message + "Out of Tune! Unable to Generate");
            throw;
        }

    }



    //Write to the file
    public static void PersistSongs(List<Song> songs){

        //Serializing the list of Character objects to a JSON string
        string jsonSongs = JsonSerializer.Serialize(songs);

        //Verified that we created a JSON representation of our list
        //Console.WriteLine(jsonCharacters);

        string filePath = "songList.json";

        File.WriteAllText(filePath, jsonSongs);

    }




}