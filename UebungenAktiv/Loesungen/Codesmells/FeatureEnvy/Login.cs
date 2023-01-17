namespace Loesungen.Codesmells.FeatureEnvy;

internal class Login
{
    private bool loginButtonAnzeigen = false;

    public void LoginButtonUmschalten() => loginButtonAnzeigen = !loginButtonAnzeigen;
}
