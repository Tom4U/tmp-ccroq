namespace Challenges.Codesmells.Dataclass;

internal class Reservierung
{
    private DateTime ankunft;
    private DateTime abreise;

    public Reservierung(DateTime ankunft, DateTime abreise)
    {
        this.ankunft = ankunft;
        this.abreise = abreise;
    }

    public DateTime GetAnkunft() => ankunft;

    public DateTime GetAbreise() => abreise;
}
