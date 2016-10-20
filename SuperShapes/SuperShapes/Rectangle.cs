/*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == ==
| Class	:		RECTANGLE
|
| Author :		Christian Norfleet			
|
| Language :	CS
|
| Class :		Contemporary Programming
|
| Instructor :	Dr. Stringfellow
|
| Due Date :	20Oct2016
|
+---------------------------------------------------------------------------- -
|
| Description : This Library provides the blueprint for Rectangle object
|
| Required Features Not Included : A child class that implements this class
|
| Known Bugs :	IF THE PROGRAM DOES NOT FUNCTION CORRECTLY IN SOME
|				SITUATIONS, DESCRIBE THE SITUATIONS AND PROBLEMS HERE
|				AND EMAIL "cynorfleet@gmail.com" per Christian Norfleet
|
*= == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == == */
namespace TheCoolestShapes
{
    public class Rectangle : a2DShape
    {
        public Rectangle()
        {
            Name = "Rectangle";
            base.apoint.x = 0.0;
            base.apoint.y = 0.0;
            area = GetArea();
            perimeter = GetPerimeter();
            ImagePath = null;
        }
        public Rectangle(double x, double y = 0.0)
        {
            Name = "Rectangle";
            base.apoint.x = x;
            base.apoint.y = y;
            area = GetArea();
            perimeter = GetPerimeter();
            ImagePath = null;
        }

        public override double GetArea()
        {
            area = base.apoint.x * base.apoint.y;
            return area;
        }

        public override double GetPerimeter()
        {
            perimeter = (base.apoint.x * 2) + (base.apoint.y * 2);
            return perimeter;
        }
    }
}
