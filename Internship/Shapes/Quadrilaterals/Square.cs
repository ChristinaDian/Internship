using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship.Shapes.Quadrilaterals
{
    class Square : Rectangle
    {
        public Square(double a) : base(a, a)
        {

        }

        public override string GetShapeType()
        {
            return "Square";
        }
    }
}
