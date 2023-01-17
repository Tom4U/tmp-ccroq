namespace Challenges.Codesmells.ShotgunSurgery;

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
        if (kontostand <= 500)
        {
            throw new Exception("Kontostand muss über 500 sein");
        }

        kontostand -= betrag;

        Console.WriteLine($"Kontostand ist {kontostand}");

    }

    public void Umbuchen(Konto sender, Konto empfaenger, int betrag)
    {
        if (sender.kontostand <= 500)
        {
            throw new Exception("Kontostand muss über 500 sein");
        }

        empfaenger.kontostand = kontostand + betrag;

    }

    public void WarnungSenden()
    {
        if (kontostand <= 500)
        {
            Console.WriteLine("Kontostand muss über 500 sein");
        }
    }
}
