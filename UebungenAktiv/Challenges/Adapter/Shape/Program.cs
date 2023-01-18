namespace Challenges.Adapter.Shape;

internal class Program
{
    public static void Main()
    {
        object[] shapes = { new Line(), new Rectangle() };
        int x1 = 10, y1 = 20;
        int x2 = 30, y2 = 60;
        int width = 40, height = 40;

        foreach (var shape in shapes)
        {
            if (shape.GetType().Name.Equals("Line"))
            {
                ((Line)shape).Draw(x1, y1, x2, y2);
            } else if (shape.GetType().Name.Equals("Rectangle"))
            {
                ((Rectangle)shape).Draw(x2, y2, width, height);
            }
        }
    }
}
