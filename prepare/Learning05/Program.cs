using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Blue",2);
        shapes.Add(square);
        
        Rectangle rectangle = new Rectangle("Red",2,4);
        shapes.Add(rectangle);

        Circle circle = new Circle("Yellow",5);
        shapes.Add(circle);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The color of the shape is {color} and has an area of {area}");
        }
    }
}