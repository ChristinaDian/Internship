using Internship.Shapes.Quadrilaterals;
using Internship.Shapes;

namespace GeometricShapes
{
    class Program
    {
        static double SumOfShapesPerimeters(List<Shape> shapes)
        {
            double sum = 0;
            foreach (Shape s in shapes)
            {
                sum += s.GetPerimeter();
            }
            return sum;
        }

        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape> {
                new Circle(10),
                new Triangle(5, 4, 3),
                new Quadrilateral(2, 3, 4, 4),
                new Rectangle(5, 10),
                new Rectangle(6, 9),
                new Square(20),
                new Triangle(5, 10, 12)
            };

            Console.WriteLine("Total sum of shapes perimeters is: " + SumOfShapesPerimeters(shapes));
        }
    }
}