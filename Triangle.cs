public class Triangle : IShape
{
    private readonly int _side1;
    private readonly int _side2;
    private readonly int _side3;

    public Triangle(int side1, int side2, int side3)
    {
        _side1 = side1;
        _side2 = side2;
        _side3 = side3;
        // Constructor
    }

    public void Draw()
    {
        Console.WriteLine("Drawing Triangle with sides " + _side1 + ", " + _side2 + ", " + _side3);
    }
}