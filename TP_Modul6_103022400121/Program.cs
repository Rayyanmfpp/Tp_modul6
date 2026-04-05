using System.Diagnostics.Contracts;

class SayaMusicTrack
{
    private int id;
    private string playcount;
    private string title;

    public SayaMusicTrack(string title)
    {
        Random random = new Random();
        this.playcount = "0";
        this.id = random.Next(10000, 100000);
        this.title = title;
    }

    public void increasePlayCount(string angka)
    {
        this.playcount = angka;
    }
    
    public void printTrackDetails()
    {
        Console.WriteLine("ID: " + this.id);
        Console.WriteLine("Title: " + this.title);
        Console.WriteLine("Play Count: " + this.playcount);
    }
}

class main
{
    public static void Main(string[] args)
    {
        SayaMusicTrack track1 = new SayaMusicTrack("Lagu Pertama");
        track1.increasePlayCount("100");
        track1.printTrackDetails();
        Console.WriteLine();
        SayaMusicTrack track2 = new SayaMusicTrack("Lagu Kedua");
        track2.increasePlayCount("250");
        track2.printTrackDetails();
    }
}
