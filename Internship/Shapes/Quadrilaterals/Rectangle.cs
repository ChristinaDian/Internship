using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship.Shapes.Quadrilaterals
{
    class Rectangle : Quadrilateral
    {
        public Rectangle(double a, double b) : base(a, a, b, b)
        {

        }
        public override string GetShapeType()
        {
            return "Rectangle";
        }
    }
}
