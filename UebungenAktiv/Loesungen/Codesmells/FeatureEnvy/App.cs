namespace Loesungen.Codesmells.FeatureEnvy;

internal class App
{
    public static void Main()
    {
        Login login = new();
        Auth auth = new();

        auth.Anmelden("user", "pass");

        if (auth.IstAngemeldet())
            login.LoginButtonUmschalten();

        auth.Abmelden();
        login.LoginButtonUmschalten();
    }
}
