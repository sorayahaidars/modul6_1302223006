public class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo>? uploadedVideos;
    public string username;

    public SayaTubeUser(string nama) 
    {
        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.username = nama;
        this.uploadedVideos = null;
    }

    public int GetTotalVideoPlayCount() 
    { 
        return 
    }

    public void AddVideo(SayaTubeVideo ) 
    { 
        
    }

    public void PrintAllVideoPlayCount() 
    { 
        
    }
}

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string judul)
    {
        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = judul;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int jumlahTontonan)
    {
        this.playCount += jumlahTontonan;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"id : {id}");
        Console.WriteLine($"judul : {title}");
        Console.WriteLine($"JumlahTontonan : {playCount}");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}