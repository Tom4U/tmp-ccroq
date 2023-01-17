namespace Loesungen.Codesmells.PrimitiveObsession;

public class Person
{
    private PersonId id;
    private Name name;
    private Adresse adresse;

    public Person(PersonId id, Name name, Adresse adresse)
    {
        // ... Initialisierung ...
    }

    public void AdresseAendern(Adresse adresse)
    {
        // ... Logik ...
    }

    public class Name
    {
        string vorname;
        string nachname;

        public Name(string vorname, string nachname)
        {
            this.vorname = vorname;
            this.nachname = nachname;
        }
    }

    public class Adresse
    {
        private string adresse;
        private string plz;
        private string ort;
        private string land;

        public Adresse(string adresse, string plz, string stadt, string land)
        {
            // ... Initialisierung ...
        }
    }

    public class PersonId : IComparable<PersonId>
    {
        private string id;

        public PersonId(string id)
        {
            // ... Initialisierung ...
        }

        public int CompareTo(PersonId? other)
        {
            return 0;
        }
    }
}
