namespace Challenges.Adapter.Shape;

internal class Line
{
    public void Draw(int x1, int y1, int x2, int y2)
    {
        Console.WriteLine($"Line from point A({ x1 }; { y1 }), to point B({ x2 }; { y2 })");
    }
}
