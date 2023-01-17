using Loesungen.Codesmells.IncompleteLibrary.Vendor;

namespace Loesungen.Codesmells.IncompleteLibrary;

internal class ExtendedGetraenkeautomat : Getraenkeautomat
{
    public HashSet<Getraenk> GetHeissgetraenke()
    {
        HashSet<Getraenk> alleGetraenke = GetGetraenke();
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
