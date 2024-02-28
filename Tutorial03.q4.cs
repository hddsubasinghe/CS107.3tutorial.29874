using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tite0304
{

    public class Shape
    {
        
        protected string ShapeType;
        protected double Area;

        
        public virtual void CalculateArea(double val1, double val2)
        {
           
        }

        
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape Type: {ShapeType}");
            Console.WriteLine($"Area: {Area}");
        }

        
        public Shape()
        {
            ShapeType = "Undefined";
            Area = 0;
        }
    }

    public class Rectangle : Shape
    {
        private double length;
        private double width;

        
        public Rectangle(double length, double width)
        {
            ShapeType = "Rectangle";
            SetDimensions(length, width);
        }

        
        public void SetDimensions(double length, double width)
        {
            this.length = length;
            this.width = width;
            CalculateArea(length, width);
        }

        public override void CalculateArea(double val1, double val2)
        {
            Area = val1 * val2;
        }
    }

    public class Circle : Shape
    {
        private double radius;

        
        public Circle(double radius)
        {
            ShapeType = "Circle";
            SetRadius(radius);
        }

        
        public void SetRadius(double radius)
        {
            this.radius = radius;
            CalculateArea(radius, 0); 
        }

       
        public override void CalculateArea(double val1, double val2)
        {
            Area = Math.PI * val1 * val1;
        }
    }

    class Program
    {
        static void Main()
        {
            // Create an instance of the Rectangle class
            Rectangle rectangle = new Rectangle(5, 3);

            // Display shape information for the rectangle
            rectangle.DisplayShapeInfo();

            Console.WriteLine(); // Adding a line break for better readability

            // Create an instance of the Circle class
            Circle circle = new Circle(4);

            // Display shape information for the circle
            circle.DisplayShapeInfo();

            Console.ReadLine(); // To keep the console window open
        }
    }
}

