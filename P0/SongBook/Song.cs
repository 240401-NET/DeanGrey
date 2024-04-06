namespace SongBook;


public class Song {
    public string? Name {get; set;}
    public double? Length {get; set;}
    public string? Genre {get; set;}

    public Song() {}

    public override string ToString() {
        return "~Name: " + Name + "~\n~Length: " + Length + "~\n~Gengre: " + Genre + "~\n";
    }
}