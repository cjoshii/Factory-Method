public class Square : IShape
{
    private readonly int _sideLength;

    public Square(int sideLength)
    {
        _sideLength = sideLength;
        // Constructor
    }

    public void Draw()
    {
        Console.WriteLine("Drawing Square with side length " + _sideLength);
    }
}
