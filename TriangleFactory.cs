public class TriangleFactory : ShapeFactory
{
    public override IShape GetShape(ShapeType shapeType, int[] dimensions)
    {
        if (shapeType != ShapeType.Triangle)
        {
            return base.GetShape(shapeType, dimensions);
        }
        return new Triangle(dimensions[0], dimensions[1], dimensions[2]);
    }
}