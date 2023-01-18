namespace Challenges.Adapter.Moveable;

internal class Driver
{
    public static void Main()
    {
        IMovable astonMartin = new AstonMartin();

        Console.WriteLine($"Aston Martin top speed is { astonMartin.GetSpeed() } Mph.");
    }
}
