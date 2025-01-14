public class Circle : IShape
{
    private readonly int _radius;

    public Circle(int radius)
    {
        _radius = radius;
        // Constructor
    }

    public void Draw()
    {
        Console.WriteLine("Drawing Circle with radius " + _radius);
    }
}
