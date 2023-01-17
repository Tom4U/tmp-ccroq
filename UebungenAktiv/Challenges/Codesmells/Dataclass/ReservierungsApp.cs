namespace Challenges.Codesmells.Dataclass;

internal class ReservierungsApp
{
    public static void Main()
    {
        try
        {
            DateTime ankunft = DateTime.Parse("20.07.2022");
            DateTime abreise = DateTime.Parse("23.07.2022");
            Reservierung reservierung = new Reservierung(ankunft, abreise);

            DauerAnzeigen(reservierung);
        }
        catch (FormatException formatException)
        {
        }
    }

    public static void DauerAnzeigen(Reservierung reservierung)
    {
        TimeSpan timeDiff = reservierung.GetAbreise() - reservierung.GetAnkunft();

        Console.WriteLine($"Der Gast bleibt { timeDiff.Days } Tage");
    }
}
