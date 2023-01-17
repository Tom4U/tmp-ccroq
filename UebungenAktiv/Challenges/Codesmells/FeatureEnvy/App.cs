namespace Challenges.Codesmells.FeatureEnvy;

internal class App
{
    public static void Main()
    {
        Login login = new(new Auth());

        login.Anmelden("user", "pass");

        if (login.IstAngemeldet()) login.LoginButtonUmschalten();

        login.Abmelden();
        login.LoginButtonUmschalten();
    }
}
