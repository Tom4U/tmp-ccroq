namespace Loesungen.Codesmells.DataClumps;

internal class Reservierung
{
    private int reservierungsNr;
    private int zimmerNr;
    private Zeitraum zeitraum;

    public Reservierung(int reservierungsNr, int zimmerNr, Zeitraum zeitraum)
    {
        this.reservierungsNr = reservierungsNr;
        this.zimmerNr = zimmerNr;
        this.zeitraum = zeitraum;
    }

    public class Zeitraum
    {
        private DateTime ankunft;
        private DateTime abreise;

        public Zeitraum(DateTime ankunft, DateTime abreise)
        {
            this.ankunft = ankunft;
            this.abreise = abreise;
        }
    }
}
