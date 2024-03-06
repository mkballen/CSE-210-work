using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square s1 = new Square("Red",3);
        shapes.Add(s1)

        Rectangle s2 = new Rectangle("blue",4);
        shape.Add(s2);

        Circle s2 = new Circle("yellow",5);
        shape.Add(s2);

        foreach (Shape s in shapes){
            string colour = s.GetColour();
            double area = s.GetArea();
            console.WriteLine($"The {colour} shape has and area of {area}.");
        }
    }
}