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


//-----------------------------Drawing Pad Example--------------------------------//


Console.WriteLine("Hello! Welcome to the Drawing Pad! Please select a category to draw from:");
Console.WriteLine("1. Animals");
Console.WriteLine("2. Vehicles");
Console.WriteLine("3. Science");

var input = Console.ReadLine();

DrawingPad? drawingPad = null;

if(input == "1")
{
    drawingPad = new AnimalDrawingPad();
}
else if(input == "2")
{
    drawingPad = new VehicleDrawingPad();
}
else if(input == "3")
{
    drawingPad = new ScienceDrawingPad();
}
else
{
    Console.WriteLine("Invalid input. Please try again.");
}

if(drawingPad != null){
    drawingPad.Draw();
}
