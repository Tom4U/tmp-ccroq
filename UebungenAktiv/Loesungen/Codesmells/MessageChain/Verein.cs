namespace Loesungen.Codesmells.MessageChain;

internal class Verein
{
    private readonly Mitglied vorsitzender;

    public Verein(Mitglied vorsitzender) => this.vorsitzender = vorsitzender;

    public Mitglied GetVorsitzender() => vorsitzender;
}
