namespace Loesungen.Codesmells.IncompleteLibrary.Vendor;

internal class Getraenkeautomat
{
    private HashSet<Getraenk> getraenke = new();

    public Getraenkeautomat()
    {
        getraenke.Add(new Getraenk("Mineralwasser", "Kaltgetränke", new decimal(1.20)));
        getraenke.Add(new Getraenk("Tafelwasser", "Kaltgetränke", new decimal(1.00)));
        getraenke.Add(new Getraenk("Orangensaft", "Kaltgetränke", new decimal(2.80)));
        getraenke.Add(new Getraenk("Kaffee", "Heißgetränke", new decimal(1.30)));
        getraenke.Add(new Getraenk("Espresso", "Heißgetränke", new decimal(1.50)));
        getraenke.Add(new Getraenk("Tee", "Heißgetränke", new decimal(1.10)));
    }

    public HashSet<Getraenk> GetGetraenke() => getraenke;
}
