namespace Loesungen.Codesmells.FeatureEnvy;

internal class Auth
{
    private bool angemeldet = false;

    public void Abmelden() => angemeldet = false;

    public void Anmelden(string benutzer, string passwort) => angemeldet = true;

    public bool IstAngemeldet() => angemeldet;
}
