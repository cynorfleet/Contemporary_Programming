using System;
using TheCoolestShapes;

namespace TheCoolestShapes
{
    public class Rectangle : a2DShape
    {

        public Rectangle(double x=0, double y=0)
        {
            this.Name = "Rectangle";
            this.apoint.x = x;
            this.apoint.y = y;
            this.area = GetArea();
            this.perimeter = GetPerimeter();
            this.ImagePath = null;
        }

        public override double GetArea()
        {
            area = apoint.x * apoint.y;
            return area;
        }

        public override double GetPerimeter()
        {
            perimeter = (apoint.x * 2) + (apoint.y * 2);
            return perimeter;
        }
    }
}
