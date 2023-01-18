namespace Loesungen.Adapter.Moveable;

internal class Driver
{
    public static void Main()
    {
        IMovable astonMartin = new AstonMartin();
        MovableKmphAdapter astonMartinKmphAdapter = new(astonMartin);

        Console.WriteLine($"Aston Martin top speed is { astonMartin.GetSpeed() } Mph.");
        Console.WriteLine($"Aston Martin top speed is { astonMartinKmphAdapter.GetSpeed() } Kmph.");
    }
}
