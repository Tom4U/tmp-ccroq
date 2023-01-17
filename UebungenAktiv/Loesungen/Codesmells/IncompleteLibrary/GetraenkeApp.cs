using Loesungen.Codesmells.IncompleteLibrary.Vendor;

namespace Loesungen.Codesmells.IncompleteLibrary;

internal class GetraenkeApp
{
    private static ExtendedGetraenkeautomat getraenkeAutomat = new();

    public static void Main()
    {
        foreach (Getraenk getraenk in getraenkeAutomat.GetHeissgetraenke())
        {
            Console.WriteLine(getraenk.GetName());
        }
    }
}
