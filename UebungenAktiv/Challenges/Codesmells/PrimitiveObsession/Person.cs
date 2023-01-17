namespace Challenges.Codesmells.PrimitiveObsession;

public class Person
{
    private string id;
    private string vorname;
    private string nachname;
    private string adresse;
    private string plz;
    private string ort;
    private string land;

    public Person(string id, string vorname, string nachname, string adresse, string plz, string stadt, string land)
    {
        // ... Initialisierung ...
    }

    public void AdresseAendern(string adresse, string plz, string stadt, string land)
    {
        // ... Logik ...
    }
}
