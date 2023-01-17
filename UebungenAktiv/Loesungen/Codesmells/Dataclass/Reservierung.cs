namespace Loesungen.Codesmells.Dataclass;

internal class Reservierung
{
    private DateTime ankunft;
    private DateTime abreise;

    public Reservierung(DateTime ankunft, DateTime abreise)
    {
        this.ankunft = ankunft;
        this.abreise = abreise;
    }

    public void DauerAnzeigen()
    {
        TimeSpan timeDiff = abreise - ankunft;

        Console.WriteLine($"Der Gast bleibt {timeDiff.Days} Tage");
    }

    public DateTime GetAnkunft() => ankunft;

    public DateTime GetAbreise() => abreise;
}
