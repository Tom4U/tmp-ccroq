namespace Loesungen.Codesmells.ShotgunSurgery;

public class Konto
{
    private string typ;
    private string kontonummer;
    private int kontostand;

    public Konto(string typ, string kontonummer, int kontostand)
    {
        this.kontostand = kontostand;
        this.typ = typ;
        this.kontonummer = kontonummer;
    }

    public void Abheben(int betrag)
    {
        KontoErfuelltAnforderungen(this, true);

        kontostand -= betrag;

        Console.WriteLine($"Kontostand ist {kontostand}");

    }

    public void Umbuchen(Konto sender, Konto empfaenger, int betrag)
    {
        KontoErfuelltAnforderungen(sender, true);

        empfaenger.kontostand += betrag;
        sender.kontostand -= betrag;
    }

    public void WarnungSenden()
    {
        KontoErfuelltAnforderungen(this, false);
    }

    private void KontoErfuelltAnforderungen(Konto konto, bool throwException)
    {
        if (konto.kontostand <= 500)
        {
            string message = "Kontostand muss über 500 sein";

            if (throwException)
            {
                throw new Exception(message);
            }
            else
            {
                Console.WriteLine(message);
            }
        }
    }
}
