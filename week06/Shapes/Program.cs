using System;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to store all shape types
            List<Shape> shapes = new List<Shape>();

            // Instantiate shapes and add them to the list
            Square redSquare = new Square("Red", 5);
            Rectangle blueRectangle = new Rectangle("Blue", 4, 6);
            Circle greenCircle = new Circle("Green", 3);

            shapes.Add(redSquare);
            shapes.Add(blueRectangle);
            shapes.Add(greenCircle);

            // Iterate through the list and dynamically invoke GetColor() and GetArea()
            Console.WriteLine("--- Shape Details ---");
            foreach (Shape shape in shapes)
            {
                string color = shape.GetColor();
                double area = shape.GetArea();

                Console.WriteLine($"Color: {color} | Area: {area:F2}");
            }
        }
    }
}