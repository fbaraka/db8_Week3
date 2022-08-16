

//CompactDisc

CompactDisk theWall = new CompactDisk("Pink Floyd", "Rock", 80);
Console.WriteLine(theWall);
Console.WriteLine();

theWall.Songs.Add("In the Flesh?");
theWall.Songs.Add("The Thin Ice");
theWall.Songs.Add("Another Brick in the Wall, Part 1");
theWall.Songs.Add("The Happiest Days of Our Lives");
theWall.Songs.Add("Another Brick in the wall, Part 2");


foreach (string song in theWall.Songs)
{
    Console.WriteLine(song);
}

Console.WriteLine();
Console.WriteLine($"This album has {theWall.SongCount()} songs in it");


class CompactDisk
{
    
    public string Artist;
    public string Genre;
    public int Duration;
    public List<string> Songs;

    public CompactDisk(string _Artist, string _Genre, int _Duration)
    {
        Artist = _Artist;
        Genre = _Genre;
        Duration = _Duration;
        Songs = new List<string>();
    }

    public int SongCount()
    {
        return Songs.Count;
    }

    public override string ToString()
    {
        return $"Artist: {Artist}\nGenre: {Genre}\nDuration: {Duration} minutes";
    }
}