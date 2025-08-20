namespace GeometricShapes;

public class Rectangle : IShape
{
    private double height;
    private double width;

    public Rectangle(double height, double width)
    {
        this.height = height;
        this.width = width;
    }
    
    public double GetArea()
    {
        return height * width;
    }

    public double GetPerimeter()
    {
        return 2 * (height + width);
    }
}