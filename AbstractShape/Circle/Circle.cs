using System;
using TheCoolestShapes;

namespace TheCoolestShapes
{
    public class Circle : a2DShape
    {
        private double radius { get; set; }
        public override double perimeter { get; set; }

        public Circle(double rad=0)
        {
            this.Name = "Circle";
            this.radius = rad;
            this.area = GetArea();
            this.perimeter = GetPerimeter();
            this.ImagePath = null;
        }

        public override double GetArea()
        {
            area = 3.14 * (radius * radius);
            return area;
        }

        public override double GetPerimeter()
        {
            this.perimeter = 2 * 3.14 * radius ;
            return this.perimeter;
        }

        public override double area { get; set; }
        public override string ImagePath { get; set; }
        public override string Name { get; set; }

        public override string ToString()
        /*-------------------------------------------- ToString -------------
       |  Function: ToString
       |
       |  Purpose: Provides a data dump of current object
       |
       |  Returns: A string 
       *-------------------------------------------------------------------*/
        {
            string output = "\nName: " + this.Name + "\nRadius: " + radius;
            output += "\nArea: " + area + "\nCircumference: " + perimeter;
            return (output);
        }
    }
}
