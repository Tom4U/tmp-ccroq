namespace Challenges.Adapter.Shape;

internal class Rectangle
{
    public void Draw(int x, int y, int width, int height)
    {
        Console.WriteLine($"Rectangle with coordinate left-down point ( { x }; { y }), width: { width }, height: { height }");
    }
}
