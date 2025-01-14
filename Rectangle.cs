using System.Drawing;

public class Rectangle : IShape
{
    private readonly int _width;
    private readonly int _height;

    public Rectangle(int width, int height)
    {
        _width = width;
        _height = height;
    }

    public void Draw()
    {
        Console.WriteLine("Drawing Rectangle with width " + _width + " and height " + _height);
    }
}
