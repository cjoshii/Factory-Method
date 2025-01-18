public abstract class ShapeFactory {

    public abstract IShape GetShape();
    
    public ShapeFactory() {
        Console.WriteLine("ShapeFactory created!");

    }

    public void Draw(){
        var shape = GetShape();
        shape.Draw();
    }
    
}