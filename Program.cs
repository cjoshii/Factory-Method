// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello! Welcome to the Shape Factory!");

var factory = new ShapeFactory();

factory.GetShape(ShapeType.Rectangle, [10, 20]).Draw();
factory.GetShape(ShapeType.Square, [10]).Draw();
factory.GetShape(ShapeType.Circle, [10]).Draw();

var triangleFactory = new TriangleFactory();
// This will throw an exception
try
{
    triangleFactory.GetShape(ShapeType.Triangle, [10, 10, 10]).Draw();
    triangleFactory.GetShape(ShapeType.Square, [10]).Draw();
    triangleFactory.GetShape(ShapeType.Hexagon, [10]).Draw();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
