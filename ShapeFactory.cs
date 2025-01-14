public class ShapeFactory : IShapeFactory {
    public virtual IShape GetShape(ShapeType shapeType, int[] dimensions) {
        if(shapeType == ShapeType.Rectangle){ 
            return new Rectangle(dimensions[0], dimensions[1]);
        }
        else if(shapeType == ShapeType.Square){
            return new Square(dimensions[0]);
        }
        else if(shapeType == ShapeType.Circle){
            return new Circle(dimensions[0]);
        }else
            throw new ArgumentException($"{shapeType} is not a supported shape type");
    }
}

public interface IShapeFactory {
    IShape GetShape(ShapeType shapeType, int[] dimensions);
}