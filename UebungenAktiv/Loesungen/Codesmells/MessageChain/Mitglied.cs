namespace Loesungen.Codesmells.MessageChain;

internal class Mitglied
{
    private Verein? verein;

    private readonly string name;

    public Mitglied(string name) => this.name = name;

    public Mitglied(string name, Verein club)
    {
        this.name = name;
        verein = club;
    }

    public Verein GetVerein() => verein;

    public string GetName() => name;

    public string GetNameVonVorsitzendem() => verein.GetVorsitzender().GetName();
}
