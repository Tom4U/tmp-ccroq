namespace Challenges.Codesmells.DataClumps;

internal class Reservierung
{
    private int reservierungsNr;
    private int zimmerNr;
    private DateTime ankunft;
    private DateTime abreise;

    public Reservierung(int reservierungsNr, int zimmerNr, DateTime ankunft, DateTime abreise)
    {
        this.reservierungsNr = reservierungsNr;
        this.zimmerNr = zimmerNr;
        this.ankunft = ankunft;
        this.abreise = abreise;
    }
}
