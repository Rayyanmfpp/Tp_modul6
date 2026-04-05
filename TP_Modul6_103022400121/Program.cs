using System.Diagnostics;

class SayaMusicTrack
{
    private int id;
    private string playCount;
    private string title;

    public SayaMusicTrack(string title)
    {
        Debug.Assert(title != null, "Judul tidak boleh null!");
        Debug.Assert(title.Length <= 100, "Judul maksimal 100 karakter!");
        Random random = new Random();
        this.playCount = "0";
        this.id = random.Next(10000, 100000);
        this.title = title;
    }

    public void increasePlayCount(int count)
    {
        try
        {
            int currentCount = int.Parse(this.playCount);

            checked
            {
                int updatedCount = currentCount + count;
                this.playCount = updatedCount.ToString();
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Play count melebihi batas maksimum integer (Overflow)!");
        }
    }    
    public void printTrackDetails()
    {
        Console.WriteLine("ID: " + this.id);
        Console.WriteLine("Title: " + this.title);
        Console.WriteLine("Play Count: " + this.playCount);
    }
}

class main
{
    static void Main(string[] args)
    {
        SayaMusicTrack lagu = new SayaMusicTrack("Lagu Kece");
        Console.WriteLine("Memulai simulasi penambahan play count...");
        lagu.printTrackDetails();

        for (int i = 0; i < 100; i++)
        {
            lagu.increasePlayCount(10000000);
        }

        lagu.printTrackDetails();
    }
}
