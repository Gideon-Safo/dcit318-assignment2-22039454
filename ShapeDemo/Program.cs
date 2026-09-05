using System;

namespace ShapeDemo
{
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double GetArea()
        {
            return Length * Width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(6, 4);

            Console.WriteLine($"Circle Area: {circle.GetArea():F2}");
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");
        }
    }
}