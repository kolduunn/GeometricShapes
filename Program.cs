namespace GeometricShapes;

class Program
{
    public static void PrintShapeInfo(IShape shape)
    {
        Console.WriteLine($"Shape area: {shape.GetArea():F2}\nShape perimeter: {shape.GetPerimeter():F2}");
    }
    static void Main(string[] args)
    {
      Circle circle = new Circle(12);
      Rectangle rectangle = new Rectangle(10, 20);
      
      PrintShapeInfo(circle);
      PrintShapeInfo(rectangle);
    }
}