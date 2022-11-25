using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship.Shapes
{
    abstract class Shape
    {
        public abstract double GetPerimeter();  // Calculate perimeter
        public abstract string GetShapeType();  // Return name of the shape
    }
}
