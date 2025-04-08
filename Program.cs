// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello! Welcome to the Shape Factory! Chose a shape to draw:");
Console.WriteLine("1. Rectangle");
Console.WriteLine("2. Square");
Console.WriteLine("3. Circle");
Console.WriteLine("4. Triangle");

var input = Console.ReadLine();
ShapeFactory? factory = null;

if (input == "1")
{
    factory = new RectangleFactory();
}
else if (input == "2")
{
    factory = new SquareFactory();
}
else if (input == "3")
{
    factory = new CircleFactory();
}
else if (input == "4")
{
    factory = new TriangleFactory();
}
else
{
    Console.WriteLine("Invalid input. Please try again.");
}

if (factory != null)
{
    factory.Draw();
}



//-----------------------------Drawing Pad Example--------------------------------//


Console.WriteLine("Hello! Welcome to the Drawing Pad! Please select a category to draw from:");
Console.WriteLine("1. Animals");
Console.WriteLine("2. Vehicles");
Console.WriteLine("3. Science");

input = Console.ReadLine();

DrawingPad? drawingPad = null;

if (input == "1")
{
    drawingPad = new AnimalDrawingPad();
}
else if (input == "2")
{
    drawingPad = new VehicleDrawingPad();
}
else if (input == "3")
{
    drawingPad = new ScienceDrawingPad();
}
else
{
    Console.WriteLine("Invalid input. Please try again.");
}

if (drawingPad != null)
{
    drawingPad.Draw();
}
