namespace Loesungen.Codesmells.Dataclass;

internal class ReservierungsApp
{
    public static void Main()
    {
        try
        {
            DateTime ankunft = DateTime.Parse("20.07.2022");
            DateTime abreise = DateTime.Parse("23.07.2022");
            Reservierung reservierung = new Reservierung(ankunft, abreise);

            reservierung.DauerAnzeigen();
        }
        catch (FormatException formatException)
        {
        }
    }
}
