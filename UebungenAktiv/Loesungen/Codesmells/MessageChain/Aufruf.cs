namespace Loesungen.Codesmells.MessageChain;

internal class Aufruf
{
    public static void Main()
    {
        Mitglied mitglied = new("Martin", new Verein(new Mitglied("Fred")));

        Console.WriteLine($"Der Vorsitzende ist {mitglied.GetNameVonVorsitzendem()}");
    }
}
