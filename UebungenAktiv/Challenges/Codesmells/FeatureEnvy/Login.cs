namespace Challenges.Codesmells.FeatureEnvy;

internal class Login
{
    private bool loginButtonAnzeigen = false;
    private Auth auth;

    public Login(Auth auth) => this.auth = auth;

    public void Abmelden() => auth.Abmelden();

    public void Anmelden(string benutzer, string passwort) => auth.Anmelden(benutzer, passwort);

    public bool IstAngemeldet() => auth.IstAngemeldet();

    public void LoginButtonUmschalten() => loginButtonAnzeigen = !loginButtonAnzeigen;
}
