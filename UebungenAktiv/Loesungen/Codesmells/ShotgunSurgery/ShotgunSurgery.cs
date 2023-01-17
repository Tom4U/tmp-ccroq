namespace Loesungen.Codesmells.ShotgunSurgery;

public class ShotgunSurgery
{
    public static void Main()
    {
        Konto konto = new("Personal", "KT123456", 1000);
        konto.Abheben(500);
        konto.WarnungSenden();
        konto.Abheben(500);
    }
}
