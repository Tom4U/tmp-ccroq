namespace Loesungen.Codesmells.IncompleteLibrary.Vendor;

internal class Getraenk
{
    private string name;
    private string kategorie;
    private decimal preis;

    public Getraenk(string name, string kategorie, decimal preis)
    {
        this.name = name;
        this.kategorie = kategorie;
        this.preis = preis;
    }

    public string GetName() => name;

    public decimal GetPreis() => preis;

    public string GetKategorie() => kategorie;
}
