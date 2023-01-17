using Challenges.Codesmells.IncompleteLibrary.Vendor;

namespace Challenges.Codesmells.IncompleteLibrary;

internal class GetraenkeApp
{
    private static Getraenkeautomat getraenkeAutomat = new();

    public static void Main()
    {
        foreach (Getraenk getraenk in GetHeissgetraenke())
        {
            Console.WriteLine(getraenk.GetName());
        }
    }

    public static HashSet<Getraenk> GetHeissgetraenke()
    {
        HashSet<Getraenk> alleGetraenke = getraenkeAutomat.GetGetraenke();
        HashSet<Getraenk> heissGetraenke = new();

        foreach (Getraenk getraenk in alleGetraenke)
        {
            if (getraenk.GetKategorie() == "Heißgetränke")
            {
                heissGetraenke.Add(getraenk);
            }
        }

        return heissGetraenke;
    }
}
