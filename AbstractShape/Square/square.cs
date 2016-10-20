using System;
using TheCoolestShapes;

namespace TheCoolestShapes
{
    public class Square : Rectangle
    {
        public Square(double x=0)
        {
            this.Name = "Square";
            this.apoint.x = x;
            this.area = GetArea();
            this.perimeter = GetPerimeter();
            this.ImagePath = null;
        }

        public override double GetArea()
        {
            area = apoint.x * 2;
            return area;
        }

        public override double GetPerimeter()
        {
            area = apoint.x * 4;
            return area;
        }
    }
}
